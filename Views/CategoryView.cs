using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Views
{
    public partial class CategoryView : Form, ICategoryView
    {

        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public CategoryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCategoryDetail);
            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    BtnSearch.PerformClick();
            };
        
        BtnNew.Click += delegate 
        {
            AddNewEvent?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(tabPageCategoryDetail);
            tabControl1.TabPages.Add(tabPageCategoryDetail);
            tabPageCategoryDetail.Text = "Nueva Categoria";
        };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryDetail);
                tabPageCategoryDetail.Text = "Editar Categoria";
            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageCategoryDetail);
                    tabControl1.TabPages.Add(tabPageCategoryList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryList);
            };
            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected category?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string CategoryId
        {
            get => TxtCategoryId.Text;
            set => TxtCategoryId.Text = value;
        }

        public string CategoryName
        {
            get => TxtCategoryName.Text;
            set => TxtCategoryName.Text = value;
        }

        public string CategoryObservation
        {
            get => TxtCategoryDescription.Text;
            set => TxtCategoryDescription.Text = value;
        }

        public string SearchValue
        {
            get => TxtSearch.Text;
            set => TxtSearch.Text = value;
        }

        public bool IsEdit
        {
            get => isEdit;
            set => isEdit = value;
        }

        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }

        public string Message
        {
            get => message;
            set => message = value;
        }


        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCategoryListBildingSource(BindingSource categoryList)
        {
            DgCategory.DataSource = categoryList;
        }
        private static CategoryView instance;

        public static CategoryView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoryView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}