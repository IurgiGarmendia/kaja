﻿using kaja.App_Code.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaja
{
    public partial class Form3 : Form
    {
        FormEdit f1;
        ANDROID_CAGE _kaxaBerria;
        kaja.App_Code.Model.Model1 _dataContext;

        public Form3()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.GetQueryable += entityInstantFeedbackSource1_GetQueryable;
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.DismissQueryable += entityInstantFeedbackSource1_DismissQueryable;
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {

            // Instantiate a new DataContext
            _dataContext = new kaja.App_Code.Model.Model1();
            // Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = _dataContext.DBCAGE;
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissQueryable event handler
            e.Tag = _dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {

            // Dispose of the DataContext
            ((kaja.App_Code.Model.Model1)e.Tag).Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCaja( "NewCage", CloseHandler);

        }

        private void CreateCaja(string windowTitle, FormClosingEventHandler closedDelegate)
        {
            _kaxaBerria = new ANDROID_CAGE();
            _kaxaBerria.AREA = "max25";
            _kaxaBerria.ESTANTE = "max10";

            f1 = new FormEdit(_kaxaBerria) { Text = windowTitle };
            f1.FormClosing += closedDelegate;
            f1.ShowDialog();
        }


        private void CloseHandler(object sender, FormClosingEventArgs e)
        {
            if (((FormEdit)sender).DialogResult == DialogResult.OK)
            {
                try
                {
                    //nwdContext.Customers.InsertOnSubmit(kaxaBerria);
                    //nwdContext.SubmitChanges();
                    //nwdContext.Refresh(RefreshMode.OverwriteCurrentValues, nwdContext.Customers);
                    //plIFS.Refresh();

                    //entityInstantFeedbackSource1.Refresh();
                   generator g = new generator();
                    string idcaga = g.GetGenerator();
                    _kaxaBerria.IDCAGE = Convert.ToInt32(idcaga);
                    _dataContext.DBCAGE.Add(_kaxaBerria);
                    _dataContext.SaveChanges();
                    entityInstantFeedbackSource1.Refresh();
                    //_dataContext.SaveChanges();





                }
                catch (Exception ex)
                {
                    HandleExcepton(ex);
                }
            }
            else
            {
                _kaxaBerria = null;
            }
        }

        private void HandleExcepton(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }



        private void CloseEditCustomerHandler(object sender, EventArgs e)
        {
            //if (((EditForm)sender).DialogResult == DialogResult.OK)
            //{
            //    try
            //    {
            //        nwdContext.SubmitChanges();
            //        nwdContext.Refresh(RefreshMode.OverwriteCurrentValues, nwdContext.Customers);
            //        plIFS.Refresh();

            //    }
            //    catch (Exception ex)
            //    {
            //        HandleExcepton(ex);
            //    }
            //}
            //customerToEdit = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //koment
            entityInstantFeedbackSource1.Refresh();
            //gridView1.FocusedRowHandle = 10;
            //gridView1.SelectRow(10);
        }
    }
}
