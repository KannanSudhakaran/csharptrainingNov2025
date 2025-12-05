namespace WinFormsAsyncProgramming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPrint = new Button();
            btnHello = new Button();
            btnThread = new Button();
            btnTask = new Button();
            btnAwaitable = new Button();
            btnResult = new Button();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(104, 104);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(241, 104);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(112, 34);
            btnHello.TabIndex = 1;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // btnThread
            // 
            btnThread.Location = new Point(104, 172);
            btnThread.Name = "btnThread";
            btnThread.Size = new Size(112, 34);
            btnThread.TabIndex = 2;
            btnThread.Text = "Thread";
            btnThread.UseVisualStyleBackColor = true;
            btnThread.Click += btnThread_Click;
            // 
            // btnTask
            // 
            btnTask.Location = new Point(257, 172);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(112, 34);
            btnTask.TabIndex = 3;
            btnTask.Text = "Task";
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnAwaitable
            // 
            btnAwaitable.Location = new Point(104, 238);
            btnAwaitable.Name = "btnAwaitable";
            btnAwaitable.Size = new Size(144, 45);
            btnAwaitable.TabIndex = 4;
            btnAwaitable.Text = "AwaitableTask";
            btnAwaitable.UseVisualStyleBackColor = true;
            btnAwaitable.Click += btnAwaitable_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(317, 251);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(213, 47);
            btnResult.TabIndex = 5;
            btnResult.Text = "AwaitableResult";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResult);
            Controls.Add(btnAwaitable);
            Controls.Add(btnTask);
            Controls.Add(btnThread);
            Controls.Add(btnHello);
            Controls.Add(btnPrint);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrint;
        private Button btnHello;
        private Button btnThread;
        private Button btnTask;
        private Button btnAwaitable;
        private Button btnResult;
    }
}
