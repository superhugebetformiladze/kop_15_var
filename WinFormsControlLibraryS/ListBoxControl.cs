﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLibraryS
{
    public partial class ListBoxControl : UserControl
    {
        public string ValueList
        {
            set
            {
                listBox.Text = value;
            }
            get { return listBox.Text; }
        }

        private void ListBox_SelectedChanged(object sender, System.EventArgs e)
        {
            eventHandler.Invoke(sender, e);
        }

        public event EventHandler eventHandler;

        /// <summary>
        /// Событие, которое вызывается при изменении элемента
        /// </summary>
        public event EventHandler SpecEvent
        {
            add { eventHandler += value; }
            remove { eventHandler -= value; }
        }
        /// <summary>
        /// User Control, содержащий ListBox и методы работы с ним
        /// </summary>
        public ListBoxControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляет элемент в ListBox
        /// </summary>
        public void Add(string item)
        {
            listBox.Items.Add(item);
        }

        /// <summary>
        /// Очищает список элементов ListBox
        /// </summary>
        public void Clear()
        {
            listBox.Items.Clear();
            listBox.ResetText();
        }
    }
}
