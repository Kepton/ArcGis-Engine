namespace Sample
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.地图加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载地图文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载特定地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存地图文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存地图文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图层管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加SHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移动图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图形绘制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制矩形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制圆形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空间查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点选查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.矩形框选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多边形查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圆形查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名称查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.地图加载ToolStripMenuItem,
            this.图层管理ToolStripMenuItem,
            this.图形绘制ToolStripMenuItem,
            this.空间查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(77, 192);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(265, 265);
            this.axMapControl1.TabIndex = 1;
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(77, 163);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(265, 28);
            this.axToolbarControl1.TabIndex = 2;
            // 
            // 地图加载ToolStripMenuItem
            // 
            this.地图加载ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载地图文档ToolStripMenuItem,
            this.加载特定地图ToolStripMenuItem,
            this.保存地图文档ToolStripMenuItem,
            this.另存地图文档ToolStripMenuItem});
            this.地图加载ToolStripMenuItem.Name = "地图加载ToolStripMenuItem";
            this.地图加载ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.地图加载ToolStripMenuItem.Text = "地图加载";
            // 
            // 加载地图文档ToolStripMenuItem
            // 
            this.加载地图文档ToolStripMenuItem.Name = "加载地图文档ToolStripMenuItem";
            this.加载地图文档ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.加载地图文档ToolStripMenuItem.Text = "加载地图文档";
            // 
            // 加载特定地图ToolStripMenuItem
            // 
            this.加载特定地图ToolStripMenuItem.Name = "加载特定地图ToolStripMenuItem";
            this.加载特定地图ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.加载特定地图ToolStripMenuItem.Text = "加载特定地图";
            // 
            // 保存地图文档ToolStripMenuItem
            // 
            this.保存地图文档ToolStripMenuItem.Name = "保存地图文档ToolStripMenuItem";
            this.保存地图文档ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存地图文档ToolStripMenuItem.Text = "保存地图文档";
            // 
            // 另存地图文档ToolStripMenuItem
            // 
            this.另存地图文档ToolStripMenuItem.Name = "另存地图文档ToolStripMenuItem";
            this.另存地图文档ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.另存地图文档ToolStripMenuItem.Text = "另存地图文档";
            // 
            // 图层管理ToolStripMenuItem
            // 
            this.图层管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加图层ToolStripMenuItem,
            this.添加SHPToolStripMenuItem,
            this.文件ToolStripMenuItem,
            this.移动图层ToolStripMenuItem});
            this.图层管理ToolStripMenuItem.Name = "图层管理ToolStripMenuItem";
            this.图层管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图层管理ToolStripMenuItem.Text = "图层管理";
            // 
            // 添加图层ToolStripMenuItem
            // 
            this.添加图层ToolStripMenuItem.Name = "添加图层ToolStripMenuItem";
            this.添加图层ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加图层ToolStripMenuItem.Text = "添加图层";
            // 
            // 添加SHPToolStripMenuItem
            // 
            this.添加SHPToolStripMenuItem.Name = "添加SHPToolStripMenuItem";
            this.添加SHPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加SHPToolStripMenuItem.Text = "添加SHP文件";
            this.添加SHPToolStripMenuItem.Click += new System.EventHandler(this.添加SHPToolStripMenuItem_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.文件ToolStripMenuItem.Text = "删除图层";
            // 
            // 移动图层ToolStripMenuItem
            // 
            this.移动图层ToolStripMenuItem.Name = "移动图层ToolStripMenuItem";
            this.移动图层ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.移动图层ToolStripMenuItem.Text = "移动图层";
            // 
            // 图形绘制ToolStripMenuItem
            // 
            this.图形绘制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.绘制线ToolStripMenuItem,
            this.绘制矩形ToolStripMenuItem,
            this.绘制文本ToolStripMenuItem,
            this.绘制圆形ToolStripMenuItem});
            this.图形绘制ToolStripMenuItem.Name = "图形绘制ToolStripMenuItem";
            this.图形绘制ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图形绘制ToolStripMenuItem.Text = "图形绘制";
            // 
            // 绘制线ToolStripMenuItem
            // 
            this.绘制线ToolStripMenuItem.Name = "绘制线ToolStripMenuItem";
            this.绘制线ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.绘制线ToolStripMenuItem.Text = "绘制线";
            // 
            // 绘制矩形ToolStripMenuItem
            // 
            this.绘制矩形ToolStripMenuItem.Name = "绘制矩形ToolStripMenuItem";
            this.绘制矩形ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.绘制矩形ToolStripMenuItem.Text = "绘制矩形";
            // 
            // 绘制文本ToolStripMenuItem
            // 
            this.绘制文本ToolStripMenuItem.Name = "绘制文本ToolStripMenuItem";
            this.绘制文本ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.绘制文本ToolStripMenuItem.Text = "绘制文本";
            // 
            // 绘制圆形ToolStripMenuItem
            // 
            this.绘制圆形ToolStripMenuItem.Name = "绘制圆形ToolStripMenuItem";
            this.绘制圆形ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.绘制圆形ToolStripMenuItem.Text = "绘制圆形";
            // 
            // 空间查询ToolStripMenuItem
            // 
            this.空间查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.点选查询ToolStripMenuItem,
            this.矩形框选ToolStripMenuItem,
            this.多边形查询ToolStripMenuItem,
            this.圆形查询ToolStripMenuItem,
            this.名称查询ToolStripMenuItem,
            this.清除选择ToolStripMenuItem});
            this.空间查询ToolStripMenuItem.Name = "空间查询ToolStripMenuItem";
            this.空间查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.空间查询ToolStripMenuItem.Text = "空间查询";
            // 
            // 点选查询ToolStripMenuItem
            // 
            this.点选查询ToolStripMenuItem.Name = "点选查询ToolStripMenuItem";
            this.点选查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.点选查询ToolStripMenuItem.Text = "点选查询";
            // 
            // 矩形框选ToolStripMenuItem
            // 
            this.矩形框选ToolStripMenuItem.Name = "矩形框选ToolStripMenuItem";
            this.矩形框选ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.矩形框选ToolStripMenuItem.Text = "矩形框选";
            // 
            // 多边形查询ToolStripMenuItem
            // 
            this.多边形查询ToolStripMenuItem.Name = "多边形查询ToolStripMenuItem";
            this.多边形查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.多边形查询ToolStripMenuItem.Text = "多边形查询";
            // 
            // 圆形查询ToolStripMenuItem
            // 
            this.圆形查询ToolStripMenuItem.Name = "圆形查询ToolStripMenuItem";
            this.圆形查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.圆形查询ToolStripMenuItem.Text = "圆形查询";
            // 
            // 名称查询ToolStripMenuItem
            // 
            this.名称查询ToolStripMenuItem.Name = "名称查询ToolStripMenuItem";
            this.名称查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.名称查询ToolStripMenuItem.Text = "名称查询";
            // 
            // 清除选择ToolStripMenuItem
            // 
            this.清除选择ToolStripMenuItem.Name = "清除选择ToolStripMenuItem";
            this.清除选择ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清除选择ToolStripMenuItem.Text = "清除选择";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 590);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 地图加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载地图文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载特定地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存地图文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存地图文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图层管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加SHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.ToolStripMenuItem 移动图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图形绘制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘制线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘制矩形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘制文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘制圆形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空间查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点选查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 矩形框选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多边形查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圆形查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名称查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除选择ToolStripMenuItem;
    }
}

