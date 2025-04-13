using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Presenters.Common;
using System;
using System.Windows.Forms;
using System.ComponentModel;


namespace Supermarket_mvp.Presenters
{
    public class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModel> categoryList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.view = view;
            this.repository = repository;

            // Asignar eventos de la vista
            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectedCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            // Inicializar fuente de datos
            categoryBindingSource = new BindingSource();
            this.view.SetCategoryListBildingSource(categoryBindingSource);

            // Cargar datos
            LoadAllCategoryList();

            // Mostrar vista
            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = this.repository.GetAll();
            categoryBindingSource.DataSource = categoryList;

        }

        private void SearchCategory(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue)
                categoryList = repository.GetAll();
            else
                categoryList = repository.GetByValue(this.view.SearchValue);
            categoryBindingSource.DataSource = categoryList;
        }

        private void AddNewCategory(object sender, EventArgs e)
        {
            this.view.IsEdit = false;
        }

        private void LoadSelectedCategoryToEdit(object sender, EventArgs e)
        {
            var category = (CategoryModel)categoryBindingSource.Current;
            this.view.CategoryId = category.CategoryId.ToString();
            this.view.CategoryName = category.Name;
            this.view.CategoryObservation = category.Description;
            this.view.IsEdit = true;
        }

        private void SaveCategory(object sender, EventArgs e)
        {
            var model = new CategoryModel();
            model.CategoryId = Convert.ToInt32(view.CategoryId);
            model.Name = this.view.CategoryName;
            model.Description = this.view.CategoryObservation;

            try
            {
                new ModelDataValidation().Validate(model);

                if (this.view.IsEdit)
                {
                    repository.Edit(model);
                    this.view.Message = "Category edited successfully";
                }
                else
                {
                    repository.Add(model);
                    this.view.Message = "Category added successfully";
                }

                this.view.IsSuccessful = true;
                LoadAllCategoryList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                this.view.IsSuccessful = false;
                this.view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            this.view.CategoryId = "0";
            this.view.CategoryName = "";
            this.view.CategoryObservation = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedCategory(object sender, EventArgs e)
        {
            try
            {
                var category = (CategoryModel)categoryBindingSource.Current;
                repository.Delete(category.CategoryId);
                this.view.IsSuccessful = true;
                this.view.Message = "Category deleted successfully";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                this.view.IsSuccessful = false;
                this.view.Message = "An error occurred: " + ex.Message;
            }
        }
    }
}
