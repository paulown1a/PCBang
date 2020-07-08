﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;
using Dbdata;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using System.Data.Entity;

namespace PC_Room
{
    public partial class FoodOrderForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Panel leftBorderBtnSecond;
        


        public FoodOrderForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtnSecond = new Panel();
            leftBorderBtn.Size = new Size(7, 48);
            leftBorderBtnSecond.Size = new Size(7, 48);
            MenuPn.Controls.Add(leftBorderBtn);
            CalulatorPn.Controls.Add(leftBorderBtnSecond);
           
            
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(192, 27, 55);
            public static Color color2 = Color.FromArgb(245, 135, 171);
            public static Color color3 = Color.FromArgb(104, 94, 197);
            public static Color color4 = Color.FromArgb(42, 152, 235);
            public static Color color5 = Color.FromArgb(199, 93, 204);
            public static Color color6 = Color.FromArgb(255, 113, 85);
            public static Color color7 = Color.FromArgb(165, 229, 158);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn!=null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                if(senderBtn==ExitBtn || senderBtn== BuyBtn)
                {
                    leftBorderBtnSecond.BackColor = color;
                    leftBorderBtnSecond.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                    leftBorderBtnSecond.Visible = true;
                    leftBorderBtnSecond.BringToFront();
                }
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
            
        }
        private void DisableButton()
        {
            if(currentBtn!=null)
            { 
                currentBtn.BackColor = Color.FromArgb(37, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color4);
           
        }

        private void BeverageBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtnSecond.Visible=false;
        }

        private void HomeIcon_Click(object sender, EventArgs e)
        {
            Reset();
           
        }

        private void ExitBtn_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            Reset();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color6);
        }

        private void BuyBtn_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void BuyBtn_MouseLeave(object sender, EventArgs e)
        {
            Reset();
        }

        private void SnackBtn_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void TicketBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            List<Product> products =
                DataRepository.Product.getbycode(102);
            productBindingSource.DataSource = products;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Order order = new Order();

            order.ProductID = (int)EntityState.Added;
        }
    }
}