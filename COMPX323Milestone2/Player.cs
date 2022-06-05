﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace COMPX323Milestone2
{
    public partial class Player : Form
    {
        public OracleConnection conn;
        public String teamid;
        public Player()
        {
            InitializeComponent();
            MessageBox.Show(teamid);



        }

        private void buttonMemShow_Click(object sender, EventArgs e)
        {

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select UserName from player where teamid like '" + teamid + "'";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader drplayer = cmd2.ExecuteReader();

            while (drplayer.Read())
            {
                String resultU = drplayer.GetString(0);
                listBoxTeamMember.Items.Add(resultU);
            }
        }
    }
}
