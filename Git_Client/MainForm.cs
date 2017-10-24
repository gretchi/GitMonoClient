﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Stage All
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            //出力を読み取れるようにする
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            //ウィンドウを表示しないようにする
            p.StartInfo.CreateNoWindow = true;
            //コマンドラインを指定（"/c"は実行後閉じるために必要）
            p.StartInfo.Arguments = @"/c git add *";
            //起動
            p.Start();
            //出力を読み取る
            string results = p.StandardOutput.ReadToEnd();
            //プロセス終了まで待機する
            //WaitForExitはReadToEndの後である必要がある
            //(親プロセス、子プロセスでブロック防止のため)
            p.WaitForExit();
            p.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CommitMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Line_Click(object sender, EventArgs e)
        {

        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Push_Click(object sender, EventArgs e)
        {
            // ウィンドウ作成
            ProgressForm pfWindow = new ProgressForm();
            pfWindow.Show();
            GitCli git = new GitCli(pfWindow);
            git.Push();

            pfWindow.WriteLog(git.output);
            

            // ウィンドウ閉じる
            // pfWindow.Close();
            // pfWindow = null;

        }

        private void newNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GetGitHistory()
        {
            string cmd = "git log --pretty = 'format:%h,%cd,%s,%d,%an,'--date = iso";
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            ProgressForm pfWindow = new ProgressForm();
            pfWindow.Show();

            pfWindow.Close();
            pfWindow = null;
        }
    }

}
