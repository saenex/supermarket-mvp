using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Supermarket_mvp.Presenters.Common;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;


            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectedPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            LoadAllPayModeList();

            this.view.Show();
        }

        private void LoadAllPayModes()
        {
           
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            // Se crea un objeto de la clase PayModeModel y se asigno los datos 
            // de las cajas de un texto de la vista
            var model = new PayModeModel();
            model.Id = Convert.ToInt32(view.PayModeId);
            model.Name = view.PayModeName;
            model.Observation = view.PayModeObservation;

            try
            {
                new ModelDataValidation().Validate(model); // valida los campos
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "PayMode actualizado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "PayMode agregado correctamente";
                }
                view.IsSuccessful = false;
                LoadAllPayModeList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                // Si ocurre una exepción se configura IsSuccesfull en false 
                //y a la propiedad Message se le asigna el mensaje de la exception
                view.IsSuccessful = false;
                LoadAllPayModeList();
            }
        }

        private void LoadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }
        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }
        private void DeleteSelectPayMode(object? sender, EventArgs e)
        {
            try
            { 
            // Se recupera el objeto de la fila seleccionada del datagridview
                var payMode = (PayModeModel)payModeBindingSource.Current;

                //Se invoca el metodo Delete del repositorio pasandole el ID del PlayMode
                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "PayMode deleted succesfuly";
                LoadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurredm, could not delete paymode";
            }

        }

        private void LoadSelectedPayModeToEdit(object? sender, EventArgs e)
        {
            // Se obtiene el objeto del datadrigview que se encuentra seleccionado
            var payMode = (PayModeModel) payModeBindingSource.Current;

            //Se cambia el contenido de las cajas de texto por el objeto recuperado
            //del datagridview
            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observation;

            // Se establece el modo de edición
            view.IsEdit = true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }
    }
}
