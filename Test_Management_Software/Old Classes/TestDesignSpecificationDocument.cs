﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Test_Management_Software.Classes
{
    class TestDesignSpecificationDocument : TableLayoutPanel
    {
        Label type;
        Label desc;
        List<String> list;
        public TestDesignSpecificationDocument(String name, string description, List<String> list2)
        {
            type = new Label();
            desc = new Label();
            this.Name = name;
            this.ColumnCount = 1;
            this.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            this.VerticalScroll.Visible = true;
            this.AutoScroll = true;
            this.AutoSize = true;
            list = list2;
            type.Text = "Test Design Specification Document";
            desc.Text = description;
            desc.AutoSize = true;
            this.Controls.Add(type);
            this.Controls.Add(desc);
            makeDocument(name, list);
        }
        //Methods to add components to panel
        //First component should be Test Document Type followed by a description
        //Next will be a panel returned by the template class
        private void makeDocument(string Name, List<string> list)
        {

            Template tp = new Template(this.Name, list);
            this.Controls.Add(tp);
        }
        public Panel getDocument()
        {
            return this;
        }
    }
}
