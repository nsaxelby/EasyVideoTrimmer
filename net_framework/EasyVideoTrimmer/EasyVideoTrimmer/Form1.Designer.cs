
namespace EasyVideoTrimmer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileBtn = new System.Windows.Forms.Button();
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.playButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pauseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectedDurationText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endSelectionText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startSelectionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxTimeLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.expectedFileSizeLabel = new System.Windows.Forms.Label();
            this.sizeCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bitRateNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.startSelectionPlayback = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.setEditOutButton = new System.Windows.Forms.Button();
            this.setInSelectButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.defaultDirectoryLabel = new System.Windows.Forms.Label();
            this.selectionRangeSlider1 = new EasyVideoTrimmer.SelectionRangeSlider();
            this.setOutputFolderBUtton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitRateNUD)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(12, 12);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // videoView1
            // 
            this.videoView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Location = new System.Drawing.Point(119, 12);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(1501, 760);
            this.videoView1.TabIndex = 1;
            this.videoView1.Text = "videoView1";
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(4, 6);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 35);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Location = new System.Drawing.Point(1545, 884);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 38);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Location = new System.Drawing.Point(119, 878);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 44);
            this.panel1.TabIndex = 4;
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(85, 6);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 34);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.selectionRangeSlider1);
            this.panel2.Location = new System.Drawing.Point(119, 826);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1507, 46);
            this.panel2.TabIndex = 5;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(120, 810);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(13, 13);
            this.currentTimeLabel.TabIndex = 8;
            this.currentTimeLabel.Text = "--";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(119, 778);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1504, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.selectedDurationText);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.endSelectionText);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.startSelectionText);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 750);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 172);
            this.panel3.TabIndex = 7;
            // 
            // selectedDurationText
            // 
            this.selectedDurationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedDurationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedDurationText.Location = new System.Drawing.Point(4, 120);
            this.selectedDurationText.Name = "selectedDurationText";
            this.selectedDurationText.Size = new System.Drawing.Size(103, 22);
            this.selectedDurationText.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Duration";
            // 
            // endSelectionText
            // 
            this.endSelectionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endSelectionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endSelectionText.Location = new System.Drawing.Point(4, 77);
            this.endSelectionText.Name = "endSelectionText";
            this.endSelectionText.Size = new System.Drawing.Size(103, 22);
            this.endSelectionText.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "End";
            // 
            // startSelectionText
            // 
            this.startSelectionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startSelectionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSelectionText.Location = new System.Drawing.Point(4, 38);
            this.startSelectionText.Name = "startSelectionText";
            this.startSelectionText.Size = new System.Drawing.Size(103, 22);
            this.startSelectionText.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SELECTION";
            // 
            // maxTimeLabel
            // 
            this.maxTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maxTimeLabel.Location = new System.Drawing.Point(1561, 810);
            this.maxTimeLabel.Name = "maxTimeLabel";
            this.maxTimeLabel.Size = new System.Drawing.Size(59, 13);
            this.maxTimeLabel.TabIndex = 9;
            this.maxTimeLabel.Text = "---";
            this.maxTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.expectedFileSizeLabel);
            this.panel4.Controls.Add(this.sizeCombo);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.bitRateNUD);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(1110, 881);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(429, 41);
            this.panel4.TabIndex = 10;
            // 
            // expectedFileSizeLabel
            // 
            this.expectedFileSizeLabel.AutoSize = true;
            this.expectedFileSizeLabel.Location = new System.Drawing.Point(383, 14);
            this.expectedFileSizeLabel.Name = "expectedFileSizeLabel";
            this.expectedFileSizeLabel.Size = new System.Drawing.Size(22, 13);
            this.expectedFileSizeLabel.TabIndex = 6;
            this.expectedFileSizeLabel.Text = "NA";
            // 
            // sizeCombo
            // 
            this.sizeCombo.DisplayMember = "1080";
            this.sizeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeCombo.FormattingEnabled = true;
            this.sizeCombo.Items.AddRange(new object[] {
            "2560",
            "2200",
            "1900",
            "1440",
            "1200",
            "1080",
            "900",
            "720",
            "480",
            "360"});
            this.sizeCombo.Location = new System.Drawing.Point(184, 6);
            this.sizeCombo.Name = "sizeCombo";
            this.sizeCombo.Size = new System.Drawing.Size(87, 28);
            this.sizeCombo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quality (1-15)";
            // 
            // bitRateNUD
            // 
            this.bitRateNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitRateNUD.Location = new System.Drawing.Point(79, 3);
            this.bitRateNUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.bitRateNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitRateNUD.Name = "bitRateNUD";
            this.bitRateNUD.Size = new System.Drawing.Size(67, 35);
            this.bitRateNUD.TabIndex = 2;
            this.bitRateNUD.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.bitRateNUD.ValueChanged += new System.EventHandler(this.bitRateNUD_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expected File Size:";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.startSelectionPlayback);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(299, 881);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(235, 43);
            this.panel5.TabIndex = 11;
            // 
            // startSelectionPlayback
            // 
            this.startSelectionPlayback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSelectionPlayback.Location = new System.Drawing.Point(178, 4);
            this.startSelectionPlayback.Name = "startSelectionPlayback";
            this.startSelectionPlayback.Size = new System.Drawing.Size(43, 36);
            this.startSelectionPlayback.TabIndex = 1;
            this.startSelectionPlayback.Text = "Start";
            this.startSelectionPlayback.UseVisualStyleBackColor = true;
            this.startSelectionPlayback.Click += new System.EventHandler(this.selectionStartPlaybackButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Selection Playback";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.Info;
            this.panel6.Controls.Add(this.setEditOutButton);
            this.panel6.Controls.Add(this.setInSelectButton);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(540, 881);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(564, 43);
            this.panel6.TabIndex = 12;
            // 
            // setEditOutButton
            // 
            this.setEditOutButton.Location = new System.Drawing.Point(211, 6);
            this.setEditOutButton.Name = "setEditOutButton";
            this.setEditOutButton.Size = new System.Drawing.Size(100, 31);
            this.setEditOutButton.TabIndex = 4;
            this.setEditOutButton.Text = "Set Edit OUT";
            this.setEditOutButton.UseVisualStyleBackColor = true;
            this.setEditOutButton.Click += new System.EventHandler(this.setEditOutButton_Click);
            // 
            // setInSelectButton
            // 
            this.setInSelectButton.Location = new System.Drawing.Point(130, 6);
            this.setInSelectButton.Name = "setInSelectButton";
            this.setInSelectButton.Size = new System.Drawing.Size(75, 31);
            this.setInSelectButton.TabIndex = 3;
            this.setInSelectButton.Text = "Set Edit IN";
            this.setInSelectButton.UseVisualStyleBackColor = true;
            this.setInSelectButton.Click += new System.EventHandler(this.setInSelectButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Selection Edit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Default Directory";
            // 
            // defaultDirectoryLabel
            // 
            this.defaultDirectoryLabel.Location = new System.Drawing.Point(14, 59);
            this.defaultDirectoryLabel.Name = "defaultDirectoryLabel";
            this.defaultDirectoryLabel.Size = new System.Drawing.Size(83, 113);
            this.defaultDirectoryLabel.TabIndex = 14;
            this.defaultDirectoryLabel.Text = "NA";
            // 
            // selectionRangeSlider1
            // 
            this.selectionRangeSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionRangeSlider1.Location = new System.Drawing.Point(4, 3);
            this.selectionRangeSlider1.Max = 1000;
            this.selectionRangeSlider1.Min = 0;
            this.selectionRangeSlider1.Name = "selectionRangeSlider1";
            this.selectionRangeSlider1.SelectedMax = 1000;
            this.selectionRangeSlider1.SelectedMin = 0;
            this.selectionRangeSlider1.Size = new System.Drawing.Size(1500, 37);
            this.selectionRangeSlider1.TabIndex = 0;
            this.selectionRangeSlider1.Value = 0;
            this.selectionRangeSlider1.ValueChangedByHand += new System.EventHandler(this.selectionRangeSlider1_ValueChangedByHand);
            // 
            // setOutputFolderBUtton
            // 
            this.setOutputFolderBUtton.Location = new System.Drawing.Point(3, 175);
            this.setOutputFolderBUtton.Name = "setOutputFolderBUtton";
            this.setOutputFolderBUtton.Size = new System.Drawing.Size(107, 23);
            this.setOutputFolderBUtton.TabIndex = 15;
            this.setOutputFolderBUtton.Text = "Set Output Folder";
            this.setOutputFolderBUtton.UseVisualStyleBackColor = true;
            this.setOutputFolderBUtton.Click += new System.EventHandler(this.setOutputFolderBUtton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Output Folder";
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.Location = new System.Drawing.Point(6, 222);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(104, 145);
            this.outputFolderLabel.TabIndex = 17;
            this.outputFolderLabel.Text = "NA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 934);
            this.Controls.Add(this.outputFolderLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.setOutputFolderBUtton);
            this.Controls.Add(this.defaultDirectoryLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.maxTimeLabel);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.videoView1);
            this.Controls.Add(this.openFileBtn);
            this.MinimumSize = new System.Drawing.Size(970, 450);
            this.Name = "Form1";
            this.Text = "Easy Video Trimmer";
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitRateNUD)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileBtn;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SelectionRangeSlider selectionRangeSlider1;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox selectedDurationText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endSelectionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox startSelectionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label maxTimeLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox sizeCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bitRateNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label expectedFileSizeLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button startSelectionPlayback;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button setEditOutButton;
        private System.Windows.Forms.Button setInSelectButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label defaultDirectoryLabel;
        private System.Windows.Forms.Button setOutputFolderBUtton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label outputFolderLabel;
    }
}

