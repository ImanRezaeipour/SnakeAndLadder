//
// Decompiled with: Decompiler.NET, Version=2.0.0.19973, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.19973
// Decompilation Started at: 1/28/2009 1:05:34 AM
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace SnakeAndLadders
{
	
	#region Namespace Import Declarations
	
	using AxMediaPlayer;
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Drawing;
	using System.Resources;
	using System.Windows.Forms;
	// Warning -- Type: SnakeAndLadders.Properties.Resources conflicts with a another imported type or namespace name,  Disabled Using Ref --> using Resources = SnakeAndLadders.Properties.Resources;
	
	#endregion
	
	public class MainBoard : Form
	{
		#region Fields
		private ToolStripMenuItem aboutToolStripMenuItem;
		private Button ActiveButton;
		private AxMediaPlayer axMediaPlayer1;
		private AxMediaPlayer axMediaPlayer2;
		private ArrayList Beads;
		private PictureBox board;
		private Button btnStart;
		private CheckBox checkBoxP2;
		private CheckBox checkBoxP3;
		private CheckBox checkBoxP4;
		private ComboBox cmbNoOfPlayers;
		private IContainer components;
		private RandomPic Dice;
		private int DiceNum;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem1;
		private ToolStripMenuItem exitToolStripMenuItem2;
		private Game game;
		private ToolStripMenuItem gameToolStripMenuItem;
		private ToolStripMenuItem gameToolStripMenuItem1;
		private ToolStripMenuItem gameToolStripMenuItem2;
		private GroupBox GroupPlayerOption;
		private GroupBox GroupPlayesStatus;
		private Timer HideLadderMovingTimer;
		private Timer HideSnakeMovingTimer;
		private Timer HideTimer;
		private int index;
		private Label label1;
		private rtynnv ladder;
		private Label LblP1;
		private Label LblP2;
		private Label LblP3;
		private Label LblP4;
		private Label LblPlayer1;
		private Label LblPlayer2;
		private Label LblPlayer3;
		private Label LblPlayer4;
		private Label LblStatusP1;
		private Label LblStatusP2;
		private Label LblStatusP3;
		private Label LblStatusP4;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem newGameToolStripMenuItem;
		private ToolStripMenuItem newGameToolStripMenuItem1;
		private ToolStripMenuItem newGameToolStripMenuItem2;
		private int num;
		private ToolStripMenuItem oFFToolStripMenuItem;
		private ToolStripMenuItem onToolStripMenuItem;
		private PictureBox P1randomPicBox;
		private PictureBox P2randomPicBox;
		private PictureBox P3randomPicBox;
		private PictureBox P4randomPicBox;
		private PictureBox PicBoxArrow1;
		private PictureBox PicBoxArrow2;
		private PictureBox PicBoxArrow3;
		private PictureBox PicBoxArrow4;
		private PictureBox pictureBox1;
		private int Player;
		private int PlayerShouldMoved;
		private string[] ranking;
		private ToolStripMenuItem restartGameToolStripMenuItem;
		private ToolStripMenuItem restartGameToolStripMenuItem1;
		private ToolStripMenuItem reToolStripMenuItem;
		private Timer ShowLadderMovingTimer;
		private Timer ShowSnakeMovingTimer;
		private Timer ShowTimer;
		private Snake snake;
		private bool SoundEnable;
		private bool start;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripSeparator toolStripSeparator3;
		private Button txtDoPlayer1;
		private Button txtDoPlayer2;
		private Button txtDoPlayer3;
		private Button txtDoPlayer4;
		private TextBox txtPlayer1;
		private TextBox txtPlayer2;
		private TextBox txtPlayer3;
		private TextBox txtPlayer4;
		private bool[] WinnerFlag;
		private int X;
		private int Y;
		#endregion
		
		#region Constructors
		
		public MainBoard ()
		{
			this.components = ((IContainer) null);
			this.game = new Game ();
			this.snake = new Snake ();
			this.ladder = new rtynnv ();
			this.Dice = new RandomPic ();
			this.Beads = new ArrayList ();
			this.PlayerShouldMoved = 0;
			this.ranking = new string[4];
			this.WinnerFlag = new bool[4];
			this.index = -1;
			this.SoundEnable = true;
			this.start = true;
			this.InitializeComponent ();
		}
		
		#endregion
		
		#region Methods
		
		private void aboutToolStripMenuItem_Click (object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult1 = MessageBox.Show ("\t\t  Snake And Ladder ver 1.0.0 \n\nProgramming and design by: Hadi Joulaee \x00a9 2008 All Rights Reserved\n\n\t\t       Author: Ha"
			+ "di Joulaee\n\n\t\tEmail: hadi.joulaee@gmail.com", "About Designer");
		}
		
		private void board_Paint (object sender, PaintEventArgs e)
		{
			int i1;
			Bitmap bitmap1 = SnakeAndLadders.Properties.Resources.board;
			e.Graphics.DrawImage (((Image) bitmap1), new Rectangle (0, 0, 654, 580));
			for (i1 = 0; (i1 < int.Parse (this.cmbNoOfPlayers.Text)); i1++)
			{
				((GameBeads) this.Beads[i1]).Draw (e.Graphics);
			}
		}
		
		private void btnStart_Click (object sender, EventArgs e)
		{
			if (this.txtPlayer1.Text == "")
			{
				System.Windows.Forms.DialogResult dialogResult1 = MessageBox.Show ("Please fill player 1\'s name.");
				return;
			}
			if (this.txtPlayer2.Text == "")
			{
				System.Windows.Forms.DialogResult dialogResult2 = MessageBox.Show ("Please fill player 2\'s name.");
				return;
			}
			if ((this.txtPlayer3.Text == "") && this.txtPlayer3.Enabled)
			{
				System.Windows.Forms.DialogResult dialogResult3 = MessageBox.Show ("Please fill player 3\'s name.");
				return;
			}
			if ((this.txtPlayer4.Text == "") && this.txtPlayer4.Enabled)
			{
				System.Windows.Forms.DialogResult dialogResult4 = MessageBox.Show ("Please fill player 4\'s name.");
				return;
			}
			if (((this.txtPlayer4.Text == this.txtPlayer1.Text) || ((this.txtPlayer4.Text == this.txtPlayer2.Text) || (this.txtPlayer4.Text == this.txtPlayer3.Text))) && (this.txtPlayer4.Text != ""))
			{
				System.Windows.Forms.DialogResult dialogResult5 = MessageBox.Show ("Player 4 already exists.");
				return;
			}
			if (((this.txtPlayer3.Text == this.txtPlayer1.Text) || ((this.txtPlayer3.Text == this.txtPlayer2.Text) || (this.txtPlayer3.Text == this.txtPlayer4.Text))) && (this.txtPlayer3.Text != ""))
			{
				System.Windows.Forms.DialogResult dialogResult6 = MessageBox.Show ("Player 3 already exists.");
				return;
			}
			if (((this.txtPlayer2.Text == this.txtPlayer1.Text) || ((this.txtPlayer2.Text == this.txtPlayer3.Text) || (this.txtPlayer2.Text == this.txtPlayer4.Text))) && (this.txtPlayer2.Text != ""))
			{
				System.Windows.Forms.DialogResult dialogResult7 = MessageBox.Show ("Player 2 already exists.");
				return;
			}
			if (((this.txtPlayer1.Text == this.txtPlayer2.Text) || ((this.txtPlayer1.Text == this.txtPlayer3.Text) || (this.txtPlayer1.Text == this.txtPlayer4.Text))) && (this.txtPlayer1.Text != ""))
			{
				System.Windows.Forms.DialogResult dialogResult8 = MessageBox.Show ("Player 1 already exists.");
				return;
			}
			this.LblPlayer1.Text = this.txtPlayer1.Text;
			this.LblPlayer2.Text = this.txtPlayer2.Text;
			this.LblPlayer3.Text = this.txtPlayer3.Text;
			this.LblPlayer4.Text = this.txtPlayer4.Text;
			this.PicBoxArrow1.Visible = true;
			char char1 = this.cmbNoOfPlayers.Text[0];
			switch (char1)
			{
				case '2':
				
				{
						this.txtDoPlayer1.Visible = true;
						this.LblStatusP1.Visible = true;
						this.txtDoPlayer2.Visible = true;
						this.LblStatusP2.Visible = true;
						this.P1randomPicBox.Image = ((Image) null);
						this.P2randomPicBox.Image = ((Image) null);
						this.P1randomPicBox.Visible = true;
						this.P2randomPicBox.Visible = true;
						break;
				}
				case '3':
				
				{
						this.txtDoPlayer1.Visible = true;
						this.LblStatusP1.Visible = true;
						this.txtDoPlayer2.Visible = true;
						this.LblStatusP2.Visible = true;
						this.txtDoPlayer3.Visible = true;
						this.LblStatusP3.Visible = true;
						this.P1randomPicBox.Image = ((Image) null);
						this.P2randomPicBox.Image = ((Image) null);
						this.P3randomPicBox.Image = ((Image) null);
						this.P1randomPicBox.Visible = true;
						this.P2randomPicBox.Visible = true;
						this.P3randomPicBox.Visible = true;
						break;
				}
				case '4':
				
				{
						this.txtDoPlayer1.Visible = true;
						this.LblStatusP1.Visible = true;
						this.txtDoPlayer2.Visible = true;
						this.LblStatusP2.Visible = true;
						this.txtDoPlayer3.Visible = true;
						this.LblStatusP3.Visible = true;
						this.txtDoPlayer4.Visible = true;
						this.LblStatusP4.Visible = true;
						this.P1randomPicBox.Image = ((Image) null);
						this.P2randomPicBox.Image = ((Image) null);
						this.P3randomPicBox.Image = ((Image) null);
						this.P4randomPicBox.Image = ((Image) null);
						this.P1randomPicBox.Visible = true;
						this.P2randomPicBox.Visible = true;
						this.P3randomPicBox.Visible = true;
						this.P4randomPicBox.Visible = true;
						break;
				}
			}
			this.btnStart.Enabled = false;
			this.checkBoxP2.Enabled = false;
			this.checkBoxP3.Enabled = false;
			this.checkBoxP4.Enabled = false;
			this.txtPlayer1.Enabled = false;
			this.txtPlayer2.Enabled = false;
			this.txtPlayer3.Enabled = false;
			this.txtPlayer4.Enabled = false;
			this.LblPlayer1.Visible = true;
			this.LblPlayer2.Visible = true;
			this.LblPlayer3.Visible = true;
			this.LblPlayer4.Visible = true;
			this.LblP1.Enabled = false;
			this.LblP2.Enabled = false;
			this.LblP3.Enabled = false;
			this.LblP4.Enabled = false;
			this.cmbNoOfPlayers.Enabled = false;
			this.restartGameToolStripMenuItem1.Enabled = true;
			this.txtDoPlayer1.Enabled = true;
		}
		
		private void cmbNoOfPlayers_SelectedIndexChanged (object sender, EventArgs e)
		{
			char char1 = this.cmbNoOfPlayers.Text[0];
			switch (char1)
			{
				case '2':
				
				{
						this.txtPlayer2.Enabled = true;
						this.checkBoxP2.Enabled = true;
						this.txtPlayer3.Enabled = false;
						this.checkBoxP3.Enabled = false;
						this.txtPlayer3.Text = "";
						this.checkBoxP3.Checked = false;
						this.txtPlayer4.Enabled = false;
						this.checkBoxP4.Enabled = false;
						this.txtPlayer4.Text = "";
						this.checkBoxP4.Checked = false;
						this.LblP1.Enabled = true;
						this.LblP2.Enabled = true;
						this.LblP3.Enabled = false;
						this.LblP4.Enabled = false;
						break;
				}
				case '3':
				
				{
						this.txtPlayer2.Enabled = true;
						this.checkBoxP2.Enabled = true;
						this.txtPlayer3.Enabled = true;
						this.checkBoxP3.Enabled = true;
						this.txtPlayer4.Enabled = false;
						this.checkBoxP4.Enabled = false;
						this.txtPlayer4.Text = "";
						this.checkBoxP4.Checked = false;
						this.LblP1.Enabled = true;
						this.LblP2.Enabled = true;
						this.LblP3.Enabled = true;
						this.LblP4.Enabled = false;
						break;
				}
				case '4':
				
				{
						this.txtPlayer2.Enabled = true;
						this.checkBoxP2.Enabled = true;
						this.txtPlayer3.Enabled = true;
						this.checkBoxP3.Enabled = true;
						this.txtPlayer4.Enabled = true;
						this.checkBoxP4.Enabled = true;
						this.LblP1.Enabled = true;
						this.LblP2.Enabled = true;
						this.LblP3.Enabled = true;
						this.LblP4.Enabled = true;
						break;
				}
			}
			this.board.Invalidate ();
		}
		
		private void cmbNoOfPlayers_TextChanged (object sender, EventArgs e)
		{
			if (((this.cmbNoOfPlayers.Text == "2") || (this.cmbNoOfPlayers.Text == "3")) || (this.cmbNoOfPlayers.Text == "4"))
			{
				return;
			}
			this.cmbNoOfPlayers.Text = "2";
		}
		
		protected override void Dispose (bool disposing)
		{
			if (disposing && (this.components != null))
			{
				((IDisposable) this.components).Dispose ();
			}
			base.Dispose (disposing);
		}
		
		private void exitToolStripMenuItem2_Click (object sender, EventArgs e)
		{
			Application.Exit ();
		}
		
		private void GroupPlayesStatus_Enter (object sender, EventArgs e)
		{
		}
		
		private void HideTimer_Tick (object sender, EventArgs e)
		{
			if (this.start)
			{
				this.ActiveButton.Enabled = false;
				if (this.SoundEnable)
				{
					this.axMediaPlayer2.FileName = "MOVING.WAV";
				}
				this.num = 42;
				this.X = ((GameBeads)this.Beads[this.Player]).GetBeadX(targetRectangle);
				this.Y = ((GameBeads) this.Beads[this.Player]).GetBeadY ();
				this.start = false;
			}
			((GameBeads) this.Beads[this.Player]).Clone (this.num, this.num);
			((GameBeads) this.Beads[this.Player]).SetLocation (this.X, this.Y);
			this.board.Invalidate ();
			this.num -= 2;
			this.X++;
			this.Y++;
			if (this.num != 0)
			{
				return;
			}
			this.start = true;
			this.HideTimer.Enabled = false;
			this.game.Play (((GameBeads) this.Beads[this.Player]), this.DiceNum, this.Player, true);
			this.board.Invalidate ();
			this.ShowTimer.Enabled = true;
		}
		
		private void InitializeComponent ()
		{
			this.components = ((IContainer) new System.ComponentModel.Container ());
			ComponentResourceManager componentResourceManager1 = new ComponentResourceManager (typeof (MainBoard));
			this.cmbNoOfPlayers = new ComboBox ();
			this.label1 = new Label ();
			this.txtPlayer1 = new TextBox ();
			this.txtPlayer2 = new TextBox ();
			this.txtPlayer3 = new TextBox ();
			this.txtPlayer4 = new TextBox ();
			this.btnStart = new Button ();
			this.txtDoPlayer1 = new Button ();
			this.checkBoxP2 = new CheckBox ();
			this.checkBoxP3 = new CheckBox ();
			this.checkBoxP4 = new CheckBox ();
			this.LblP1 = new Label ();
			this.LblP2 = new Label ();
			this.LblP3 = new Label ();
			this.LblP4 = new Label ();
			this.GroupPlayerOption = new GroupBox ();
			this.pictureBox1 = new PictureBox ();
			this.gameToolStripMenuItem = new ToolStripMenuItem ();
			this.newGameToolStripMenuItem = new ToolStripMenuItem ();
			this.restartGameToolStripMenuItem = new ToolStripMenuItem ();
			this.toolStripSeparator1 = new ToolStripSeparator ();
			this.exitToolStripMenuItem = new ToolStripMenuItem ();
			this.LblPlayer1 = new Label ();
			this.LblPlayer2 = new Label ();
			this.LblPlayer3 = new Label ();
			this.LblPlayer4 = new Label ();
			this.GroupPlayesStatus = new GroupBox ();
			this.LblStatusP4 = new Label ();
			this.LblStatusP3 = new Label ();
			this.LblStatusP2 = new Label ();
			this.LblStatusP1 = new Label ();
			this.txtDoPlayer4 = new Button ();
			this.txtDoPlayer3 = new Button ();
			this.txtDoPlayer2 = new Button ();
			this.PicBoxArrow4 = new PictureBox ();
			this.PicBoxArrow3 = new PictureBox ();
			this.PicBoxArrow2 = new PictureBox ();
			this.P1randomPicBox = new PictureBox ();
			this.PicBoxArrow1 = new PictureBox ();
			this.P4randomPicBox = new PictureBox ();
			this.P3randomPicBox = new PictureBox ();
			this.P2randomPicBox = new PictureBox ();
			this.ShowTimer = new Timer (this.components);
			this.HideTimer = new Timer (this.components);
			this.axMediaPlayer1 = new AxMediaPlayer ();
			this.axMediaPlayer2 = new AxMediaPlayer ();
			this.ShowSnakeMovingTimer = new Timer (this.components);
			this.HideSnakeMovingTimer = new Timer (this.components);
			this.ShowLadderMovingTimer = new Timer (this.components);
			this.HideLadderMovingTimer = new Timer (this.components);
			this.menuStrip1 = new MenuStrip ();
			this.gameToolStripMenuItem2 = new ToolStripMenuItem ();
			this.newGameToolStripMenuItem2 = new ToolStripMenuItem ();
			this.restartGameToolStripMenuItem1 = new ToolStripMenuItem ();
			this.toolStripSeparator3 = new ToolStripSeparator ();
			this.toolStripMenuItem2 = new ToolStripMenuItem ();
			this.onToolStripMenuItem = new ToolStripMenuItem ();
			this.oFFToolStripMenuItem = new ToolStripMenuItem ();
			this.toolStripSeparator2 = new ToolStripSeparator ();
			this.exitToolStripMenuItem2 = new ToolStripMenuItem ();
			this.aboutToolStripMenuItem = new ToolStripMenuItem ();
			this.gameToolStripMenuItem1 = new ToolStripMenuItem ();
			this.newGameToolStripMenuItem1 = new ToolStripMenuItem ();
			this.reToolStripMenuItem = new ToolStripMenuItem ();
			this.exitToolStripMenuItem1 = new ToolStripMenuItem ();
			this.toolStripMenuItem1 = new ToolStripMenuItem ();
			this.board = new PictureBox ();
			this.GroupPlayerOption.SuspendLayout ();
			((ISupportInitialize) this.pictureBox1).BeginInit ();
			this.GroupPlayesStatus.SuspendLayout ();
			((ISupportInitialize) this.PicBoxArrow4).BeginInit ();
			((ISupportInitialize) this.PicBoxArrow3).BeginInit ();
			((ISupportInitialize) this.PicBoxArrow2).BeginInit ();
			((ISupportInitialize) this.P1randomPicBox).BeginInit ();
			((ISupportInitialize) this.PicBoxArrow1).BeginInit ();
			((ISupportInitialize) this.P4randomPicBox).BeginInit ();
			((ISupportInitialize) this.P3randomPicBox).BeginInit ();
			((ISupportInitialize) this.P2randomPicBox).BeginInit ();
			((ISupportInitialize) this.axMediaPlayer1).BeginInit ();
			((ISupportInitialize) this.axMediaPlayer2).BeginInit ();
			this.menuStrip1.SuspendLayout ();
			((ISupportInitialize) this.board).BeginInit ();
			base.SuspendLayout ();
			this.cmbNoOfPlayers.FormattingEnabled = true;
			this.cmbNoOfPlayers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmbNoOfPlayers.Items.AddRange (new object[] { "2", "3", "4" });
			this.cmbNoOfPlayers.Location = new Point (144, 34);
			this.cmbNoOfPlayers.MaxDropDownItems = 4;
			this.cmbNoOfPlayers.MaxLength = 1;
			this.cmbNoOfPlayers.Name = "cmbNoOfPlayers";
			this.cmbNoOfPlayers.Size = new System.Drawing.Size (44, 21);
			this.cmbNoOfPlayers.TabIndex = 2;
			this.cmbNoOfPlayers.Text = "2";
			this.cmbNoOfPlayers.SelectedIndexChanged += new EventHandler (this.cmbNoOfPlayers_SelectedIndexChanged);
			this.cmbNoOfPlayers.TextChanged += new EventHandler (this.cmbNoOfPlayers_TextChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new Point (65, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (75, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "No. of players:";
			this.txtPlayer1.Location = new Point (86, 72);
			this.txtPlayer1.MaxLength = 16;
			this.txtPlayer1.Name = "txtPlayer1";
			this.txtPlayer1.Size = new System.Drawing.Size (101, 20);
			this.txtPlayer1.TabIndex = 4;
			this.txtPlayer1.Text = "hadi";
			this.txtPlayer2.Location = new Point (86, 101);
			this.txtPlayer2.MaxLength = 16;
			this.txtPlayer2.Name = "txtPlayer2";
			this.txtPlayer2.Size = new System.Drawing.Size (102, 20);
			this.txtPlayer2.TabIndex = 5;
			this.txtPlayer2.Text = "mehdi";
			this.txtPlayer3.Enabled = false;
			this.txtPlayer3.Location = new Point (86, 131);
			this.txtPlayer3.MaxLength = 16;
			this.txtPlayer3.Name = "txtPlayer3";
			this.txtPlayer3.Size = new System.Drawing.Size (102, 20);
			this.txtPlayer3.TabIndex = 6;
			this.txtPlayer3.Text = "amir";
			this.txtPlayer4.Enabled = false;
			this.txtPlayer4.Location = new Point (86, 161);
			this.txtPlayer4.MaxLength = 16;
			this.txtPlayer4.Name = "txtPlayer4";
			this.txtPlayer4.Size = new System.Drawing.Size (101, 20);
			this.txtPlayer4.TabIndex = 7;
			this.txtPlayer4.Text = "mohammad";
			this.btnStart.Location = new Point (85, 192);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size (103, 24);
			this.btnStart.TabIndex = 8;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new EventHandler (this.btnStart_Click);
			this.txtDoPlayer1.Enabled = false;
			this.txtDoPlayer1.Location = new Point (201, 53);
			this.txtDoPlayer1.Name = "txtDoPlayer1";
			this.txtDoPlayer1.Size = new System.Drawing.Size (85, 24);
			this.txtDoPlayer1.TabIndex = 10;
			this.txtDoPlayer1.Text = "Play";
			this.txtDoPlayer1.UseVisualStyleBackColor = true;
			this.txtDoPlayer1.Visible = false;
			this.txtDoPlayer1.Click += new EventHandler (this.txtDo_Click);
			this.checkBoxP2.AutoSize = true;
			this.checkBoxP2.Checked = true;
			this.checkBoxP2.CheckState = CheckState.Checked;
			this.checkBoxP2.Location = new Point (216, 100);
			this.checkBoxP2.Name = "checkBoxP2";
			this.checkBoxP2.Size = new System.Drawing.Size (70, 17);
			this.checkBoxP2.TabIndex = 13;
			this.checkBoxP2.Text = "Cpu User";
			this.checkBoxP2.UseVisualStyleBackColor = true;
			this.checkBoxP3.AutoSize = true;
			this.checkBoxP3.Enabled = false;
			this.checkBoxP3.Location = new Point (216, 133);
			this.checkBoxP3.Name = "checkBoxP3";
			this.checkBoxP3.Size = new System.Drawing.Size (70, 17);
			this.checkBoxP3.TabIndex = 14;
			this.checkBoxP3.Text = "Cpu User";
			this.checkBoxP3.UseVisualStyleBackColor = true;
			this.checkBoxP4.AutoSize = true;
			this.checkBoxP4.Enabled = false;
			this.checkBoxP4.Location = new Point (216, 163);
			this.checkBoxP4.Name = "checkBoxP4";
			this.checkBoxP4.Size = new System.Drawing.Size (70, 17);
			this.checkBoxP4.TabIndex = 15;
			this.checkBoxP4.Text = "Cpu User";
			this.checkBoxP4.UseVisualStyleBackColor = true;
			this.LblP1.AutoSize = true;
			this.LblP1.Location = new Point (29, 75);
			this.LblP1.Name = "LblP1";
			this.LblP1.Size = new System.Drawing.Size (45, 13);
			this.LblP1.TabIndex = 16;
			this.LblP1.Text = "Player 1";
			this.LblP2.AutoSize = true;
			this.LblP2.Location = new Point (29, 104);
			this.LblP2.Name = "LblP2";
			this.LblP2.Size = new System.Drawing.Size (45, 13);
			this.LblP2.TabIndex = 17;
			this.LblP2.Text = "Player 2";
			this.LblP3.AutoSize = true;
			this.LblP3.Location = new Point (29, 134);
			this.LblP3.Name = "LblP3";
			this.LblP3.Size = new System.Drawing.Size (45, 13);
			this.LblP3.TabIndex = 18;
			this.LblP3.Text = "Player 3";
			this.LblP4.AutoSize = true;
			this.LblP4.Location = new Point (29, 164);
			this.LblP4.Name = "LblP4";
			this.LblP4.Size = new System.Drawing.Size (45, 13);
			this.LblP4.TabIndex = 19;
			this.LblP4.Text = "Player 4";
			this.GroupPlayerOption.Controls.Add (((Control) this.pictureBox1));
			this.GroupPlayerOption.Controls.Add (((Control) this.LblP4));
			this.GroupPlayerOption.Controls.Add (((Control) this.LblP3));
			this.GroupPlayerOption.Controls.Add (((Control) this.LblP2));
			this.GroupPlayerOption.Controls.Add (((Control) this.LblP1));
			this.GroupPlayerOption.Controls.Add (((Control) this.checkBoxP4));
			this.GroupPlayerOption.Controls.Add (((Control) this.checkBoxP3));
			this.GroupPlayerOption.Controls.Add (((Control) this.checkBoxP2));
			this.GroupPlayerOption.Controls.Add (((Control) this.btnStart));
			this.GroupPlayerOption.Controls.Add (((Control) this.txtPlayer4));
			this.GroupPlayerOption.Controls.Add (((Control) this.txtPlayer3));
			this.GroupPlayerOption.Controls.Add (((Control) this.txtPlayer2));
			this.GroupPlayerOption.Controls.Add (((Control) this.txtPlayer1));
			this.GroupPlayerOption.Controls.Add (((Control) this.label1));
			this.GroupPlayerOption.Controls.Add (((Control) this.cmbNoOfPlayers));
			this.GroupPlayerOption.Location = new Point (652, 397);
			this.GroupPlayerOption.Name = "GroupPlayerOption";
			this.GroupPlayerOption.Size = new System.Drawing.Size (353, 238);
			this.GroupPlayerOption.TabIndex = 21;
			this.GroupPlayerOption.TabStop = false;
			this.GroupPlayerOption.Text = "Players Settings";
			this.pictureBox1.Image = ((Image) SnakeAndLadders.Properties.Resources.SmalBeads);
			this.pictureBox1.Location = new Point (5, 68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size (25, 116);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			this.gameToolStripMenuItem.DropDownItems.AddRange (new ToolStripItem[] { ((ToolStripItem) this.newGameToolStripMenuItem), ((ToolStripItem) this.restartGameToolStripMenuItem), ((ToolStripItem) this.toolStripSeparator1), ((ToolStripItem) this.exitToolStripMenuItem) });
			this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
			this.gameToolStripMenuItem.Size = new System.Drawing.Size (46, 20);
			this.gameToolStripMenuItem.Text = "Game";
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size (140, 22);
			this.newGameToolStripMenuItem.Text = "&New Game";
			this.newGameToolStripMenuItem.Click += new EventHandler (this.newGameToolStripMenuItem_Click);
			this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
			this.restartGameToolStripMenuItem.Size = new System.Drawing.Size (140, 22);
			this.restartGameToolStripMenuItem.Text = "&Restart Game";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size (137, 6);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size (140, 22);
			this.LblPlayer1.AutoSize = true;
			this.LblPlayer1.Font = new System.Drawing.Font ("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, byte.MinValue);
			this.LblPlayer1.ForeColor = Color.Brown;
			this.LblPlayer1.Location = new Point (52, 58);
			this.LblPlayer1.Name = "LblPlayer1";
			this.LblPlayer1.Size = new System.Drawing.Size (0, 13);
			this.LblPlayer1.TabIndex = 32;
			this.LblPlayer1.Visible = false;
			this.LblPlayer2.AutoSize = true;
			this.LblPlayer2.Font = new System.Drawing.Font ("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, byte.MinValue);
			this.LblPlayer2.ForeColor = Color.RoyalBlue;
			this.LblPlayer2.Location = new Point (52, 91);
			this.LblPlayer2.Name = "LblPlayer2";
			this.LblPlayer2.Size = new System.Drawing.Size (0, 13);
			this.LblPlayer2.TabIndex = 33;
			this.LblPlayer2.Visible = false;
			this.LblPlayer3.AutoSize = true;
			this.LblPlayer3.Font = new System.Drawing.Font ("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, byte.MinValue);
			this.LblPlayer3.ForeColor = Color.Green;
			this.LblPlayer3.Location = new Point (52, 124);
			this.LblPlayer3.Name = "LblPlayer3";
			this.LblPlayer3.Size = new System.Drawing.Size (0, 13);
			this.LblPlayer3.TabIndex = 34;
			this.LblPlayer3.Visible = false;
			this.LblPlayer4.AutoSize = true;
			this.LblPlayer4.Font = new System.Drawing.Font ("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, byte.MinValue);
			this.LblPlayer4.ForeColor = Color.Gold;
			this.LblPlayer4.Location = new Point (52, 157);
			this.LblPlayer4.Name = "LblPlayer4";
			this.LblPlayer4.Size = new System.Drawing.Size (0, 13);
			this.LblPlayer4.TabIndex = 35;
			this.LblPlayer4.Visible = false;
			this.GroupPlayesStatus.Controls.Add (((Control) this.LblStatusP4));
			this.GroupPlayesStatus.Controls.Add (((Control) this.LblStatusP3));
			this.GroupPlayesStatus.Controls.Add (((Control) this.LblStatusP2));
			this.GroupPlayesStatus.Controls.Add (((Control) this.LblStatusP1));
			this.GroupPlayesStatus.Controls.Add (((Control) this.txtDoPlayer4));
			this.GroupPlayesStatus.Controls.Add (((Control) this.txtDoPlayer3));
			this.GroupPlayesStatus.Controls.Add (((Control) this.txtDoPlayer2));
			this.GroupPlayesStatus.Controls.Add (((Control) this.PicBoxArrow4));
			this.GroupPlayesStatus.Controls.Add (((Control) this.PicBoxArrow3));
			this.GroupPlayesStatus.Controls.Add (((Control) this.PicBoxArrow2));
			this.GroupPlayesStatus.Controls.Add (((Control) this.LblPlayer4));
			this.GroupPlayesStatus.Controls.Add (((Control) this.LblPlayer3));
			this.GroupPlayesStatus.Controls.Add (((Control) this.LblPlayer2));
			this.GroupPlayesStatus.Controls.Add (((Control) this.LblPlayer1));
			this.GroupPlayesStatus.Controls.Add (((Control) this.P1randomPicBox));
			this.GroupPlayesStatus.Controls.Add (((Control) this.PicBoxArrow1));
			this.GroupPlayesStatus.Controls.Add (((Control) this.P4randomPicBox));
			this.GroupPlayesStatus.Controls.Add (((Control) this.P3randomPicBox));
			this.GroupPlayesStatus.Controls.Add (((Control) this.P2randomPicBox));
			this.GroupPlayesStatus.Controls.Add (((Control) this.txtDoPlayer1));
			this.GroupPlayesStatus.Location = new Point (652, 107);
			this.GroupPlayesStatus.Name = "GroupPlayesStatus";
			this.GroupPlayesStatus.Size = new System.Drawing.Size (353, 232);
			this.GroupPlayesStatus.TabIndex = 39;
			this.GroupPlayesStatus.TabStop = false;
			this.GroupPlayesStatus.Text = "Playes Status";
			this.GroupPlayesStatus.Enter += new EventHandler (this.GroupPlayesStatus_Enter);
			this.LblStatusP4.AutoSize = true;
			this.LblStatusP4.Font = new System.Drawing.Font ("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
			this.LblStatusP4.ForeColor = Color.Firebrick;
			this.LblStatusP4.Location = new Point (291, 158);
			this.LblStatusP4.Name = "LblStatusP4";
			this.LblStatusP4.Size = new System.Drawing.Size (32, 13);
			this.LblStatusP4.TabIndex = 45;
			this.LblStatusP4.Text = "IDLE";
			this.LblStatusP4.Visible = false;
			this.LblStatusP3.AutoSize = true;
			this.LblStatusP3.Font = new System.Drawing.Font ("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
			this.LblStatusP3.ForeColor = Color.Firebrick;
			this.LblStatusP3.Location = new Point (291, 124);
			this.LblStatusP3.Name = "LblStatusP3";
			this.LblStatusP3.Size = new System.Drawing.Size (32, 13);
			this.LblStatusP3.TabIndex = 44;
			this.LblStatusP3.Text = "IDLE";
			this.LblStatusP3.Visible = false;
			this.LblStatusP2.AutoSize = true;
			this.LblStatusP2.Font = new System.Drawing.Font ("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
			this.LblStatusP2.ForeColor = Color.Firebrick;
			this.LblStatusP2.Location = new Point (291, 91);
			this.LblStatusP2.Name = "LblStatusP2";
			this.LblStatusP2.Size = new System.Drawing.Size (32, 13);
			this.LblStatusP2.TabIndex = 43;
			this.LblStatusP2.Text = "IDLE";
			this.LblStatusP2.Visible = false;
			this.LblStatusP1.AutoSize = true;
			this.LblStatusP1.Font = new System.Drawing.Font ("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
			this.LblStatusP1.ForeColor = Color.Firebrick;
			this.LblStatusP1.Location = new Point (291, 58);
			this.LblStatusP1.Name = "LblStatusP1";
			this.LblStatusP1.Size = new System.Drawing.Size (32, 13);
			this.LblStatusP1.TabIndex = 42;
			this.LblStatusP1.Text = "IDLE";
			this.LblStatusP1.Visible = false;
			this.txtDoPlayer4.Enabled = false;
			this.txtDoPlayer4.Location = new Point (201, 152);
			this.txtDoPlayer4.Name = "txtDoPlayer4";
			this.txtDoPlayer4.Size = new System.Drawing.Size (85, 24);
			this.txtDoPlayer4.TabIndex = 41;
			this.txtDoPlayer4.Text = "Play";
			this.txtDoPlayer4.UseVisualStyleBackColor = true;
			this.txtDoPlayer4.Visible = false;
			this.txtDoPlayer4.Click += new EventHandler (this.txtDoPlayer4_Click);
			this.txtDoPlayer3.Enabled = false;
			this.txtDoPlayer3.Location = new Point (201, 119);
			this.txtDoPlayer3.Name = "txtDoPlayer3";
			this.txtDoPlayer3.Size = new System.Drawing.Size (85, 24);
			this.txtDoPlayer3.TabIndex = 40;
			this.txtDoPlayer3.Text = "Play";
			this.txtDoPlayer3.UseVisualStyleBackColor = true;
			this.txtDoPlayer3.Visible = false;
			this.txtDoPlayer3.Click += new EventHandler (this.txtDoPlayer3_Click);
			this.txtDoPlayer2.Enabled = false;
			this.txtDoPlayer2.Location = new Point (201, 86);
			this.txtDoPlayer2.Name = "txtDoPlayer2";
			this.txtDoPlayer2.Size = new System.Drawing.Size (85, 24);
			this.txtDoPlayer2.TabIndex = 39;
			this.txtDoPlayer2.Text = "Play";
			this.txtDoPlayer2.UseVisualStyleBackColor = true;
			this.txtDoPlayer2.Visible = false;
			this.txtDoPlayer2.Click += new EventHandler (this.txtDoPlayer2_Click);
			this.PicBoxArrow4.Image = ((Image) SnakeAndLadders.Properties.Resources.arrow);
			this.PicBoxArrow4.Location = new Point (17, 155);
			this.PicBoxArrow4.Name = "PicBoxArrow4";
			this.PicBoxArrow4.Size = new System.Drawing.Size (27, 20);
			this.PicBoxArrow4.SizeMode = PictureBoxSizeMode.AutoSize;
			this.PicBoxArrow4.TabIndex = 38;
			this.PicBoxArrow4.TabStop = false;
			this.PicBoxArrow4.Visible = false;
			this.PicBoxArrow3.Image = ((Image) SnakeAndLadders.Properties.Resources.arrow);
			this.PicBoxArrow3.Location = new Point (17, 122);
			this.PicBoxArrow3.Name = "PicBoxArrow3";
			this.PicBoxArrow3.Size = new System.Drawing.Size (27, 20);
			this.PicBoxArrow3.SizeMode = PictureBoxSizeMode.AutoSize;
			this.PicBoxArrow3.TabIndex = 37;
			this.PicBoxArrow3.TabStop = false;
			this.PicBoxArrow3.Visible = false;
			this.PicBoxArrow2.Image = ((Image) SnakeAndLadders.Properties.Resources.arrow);
			this.PicBoxArrow2.Location = new Point (17, 89);
			this.PicBoxArrow2.Name = "PicBoxArrow2";
			this.PicBoxArrow2.Size = new System.Drawing.Size (27, 20);
			this.PicBoxArrow2.SizeMode = PictureBoxSizeMode.AutoSize;
			this.PicBoxArrow2.TabIndex = 36;
			this.PicBoxArrow2.TabStop = false;
			this.PicBoxArrow2.Visible = false;
			this.P1randomPicBox.Location = new Point (165, 50);
			this.P1randomPicBox.Name = "P1randomPicBox";
			this.P1randomPicBox.Size = new System.Drawing.Size (26, 27);
			this.P1randomPicBox.TabIndex = 31;
			this.P1randomPicBox.TabStop = false;
			this.PicBoxArrow1.Image = ((Image) SnakeAndLadders.Properties.Resources.arrow);
			this.PicBoxArrow1.Location = new Point (17, 56);
			this.PicBoxArrow1.Name = "PicBoxArrow1";
			this.PicBoxArrow1.Size = new System.Drawing.Size (27, 20);
			this.PicBoxArrow1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.PicBoxArrow1.TabIndex = 30;
			this.PicBoxArrow1.TabStop = false;
			this.PicBoxArrow1.Visible = false;
			this.P4randomPicBox.Location = new Point (165, 149);
			this.P4randomPicBox.Name = "P4randomPicBox";
			this.P4randomPicBox.Size = new System.Drawing.Size (26, 27);
			this.P4randomPicBox.TabIndex = 29;
			this.P4randomPicBox.TabStop = false;
			this.P3randomPicBox.Location = new Point (165, 116);
			this.P3randomPicBox.Name = "P3randomPicBox";
			this.P3randomPicBox.Size = new System.Drawing.Size (26, 27);
			this.P3randomPicBox.TabIndex = 28;
			this.P3randomPicBox.TabStop = false;
			this.P2randomPicBox.Location = new Point (165, 83);
			this.P2randomPicBox.Name = "P2randomPicBox";
			this.P2randomPicBox.Size = new System.Drawing.Size (26, 27);
			this.P2randomPicBox.TabIndex = 27;
			this.P2randomPicBox.TabStop = false;
			this.ShowTimer.Interval = 10;
			this.ShowTimer.Tick += new EventHandler (this.ShowTimer_Tick);
			this.HideTimer.Interval = 10;
			this.HideTimer.Tick += new EventHandler (this.HideTimer_Tick);
			this.axMediaPlayer1.Location = new Point (269, 7);
			this.axMediaPlayer1.Name = "axMediaPlayer1";
			this.axMediaPlayer1.OcxState = ((AxHost.State) componentResourceManager1.GetObject ("axMediaPlayer1.OcxState"));
			this.axMediaPlayer1.Size = new System.Drawing.Size (131, 53);
			this.axMediaPlayer1.TabIndex = 40;
			this.axMediaPlayer1.Visible = false;
			this.axMediaPlayer2.Location = new Point (447, 7);
			this.axMediaPlayer2.Name = "axMediaPlayer2";
			this.axMediaPlayer2.OcxState = ((AxHost.State) componentResourceManager1.GetObject ("axMediaPlayer2.OcxState"));
			this.axMediaPlayer2.Size = new System.Drawing.Size (97, 53);
			this.axMediaPlayer2.TabIndex = 41;
			this.axMediaPlayer2.Visible = false;
			this.ShowSnakeMovingTimer.Interval = 10;
			this.ShowSnakeMovingTimer.Tick += new EventHandler (this.timer1_Tick);
			this.HideSnakeMovingTimer.Interval = 10;
			this.HideSnakeMovingTimer.Tick += new EventHandler (this.timer2_Tick);
			this.ShowLadderMovingTimer.Interval = 10;
			this.ShowLadderMovingTimer.Tick += new EventHandler (this.timer3_Tick);
			this.HideLadderMovingTimer.Interval = 10;
			this.HideLadderMovingTimer.Tick += new EventHandler (this.timer4_Tick);
			this.menuStrip1.Items.AddRange (new ToolStripItem[] { ((ToolStripItem) this.gameToolStripMenuItem2), ((ToolStripItem) this.aboutToolStripMenuItem) });
			this.menuStrip1.Location = new Point (0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size (1006, 24);
			this.menuStrip1.TabIndex = 42;
			this.menuStrip1.Text = "menuStrip1";
			this.gameToolStripMenuItem2.DropDownItems.AddRange (new ToolStripItem[] { ((ToolStripItem) this.newGameToolStripMenuItem2), ((ToolStripItem) this.restartGameToolStripMenuItem1), ((ToolStripItem) this.toolStripSeparator3), ((ToolStripItem) this.toolStripMenuItem2), ((ToolStripItem) this.toolStripSeparator2), ((ToolStripItem) this.exitToolStripMenuItem2) });
			this.gameToolStripMenuItem2.Name = "gameToolStripMenuItem2";
			this.gameToolStripMenuItem2.Size = new System.Drawing.Size (46, 20);
			this.gameToolStripMenuItem2.Text = "&Game";
			this.newGameToolStripMenuItem2.Image = ((Image) SnakeAndLadders.Properties.Resources.NewGame);
			this.newGameToolStripMenuItem2.Name = "newGameToolStripMenuItem2";
			this.newGameToolStripMenuItem2.ShortcutKeys = Keys.F2;
			this.newGameToolStripMenuItem2.Size = new System.Drawing.Size (159, 22);
			this.newGameToolStripMenuItem2.Text = "&New Game";
			this.newGameToolStripMenuItem2.Click += new EventHandler (this.newGameToolStripMenuItem2_Click);
			this.restartGameToolStripMenuItem1.Image = ((Image) SnakeAndLadders.Properties.Resources.RestartGame);
			this.restartGameToolStripMenuItem1.Name = "restartGameToolStripMenuItem1";
			this.restartGameToolStripMenuItem1.ShortcutKeys = Keys.F4;
			this.restartGameToolStripMenuItem1.Size = new System.Drawing.Size (159, 22);
			this.restartGameToolStripMenuItem1.Text = "&Restart Game";
			this.restartGameToolStripMenuItem1.Click += new EventHandler (this.restartGameToolStripMenuItem1_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size (156, 6);
			this.toolStripMenuItem2.DropDownItems.AddRange (new ToolStripItem[] { ((ToolStripItem) this.onToolStripMenuItem), ((ToolStripItem) this.oFFToolStripMenuItem) });
			this.toolStripMenuItem2.Image = ((Image) SnakeAndLadders.Properties.Resources.Speaker);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.ShortcutKeys = Keys.F8;
			this.toolStripMenuItem2.Size = new System.Drawing.Size (159, 22);
			this.toolStripMenuItem2.Text = "&Sound";
			this.toolStripMenuItem2.Click += new EventHandler (this.toolStripMenuItem2_Click_1);
			this.onToolStripMenuItem.Checked = true;
			this.onToolStripMenuItem.CheckState = CheckState.Checked;
			this.onToolStripMenuItem.Name = "onToolStripMenuItem";
			this.onToolStripMenuItem.Size = new System.Drawing.Size (94, 22);
			this.onToolStripMenuItem.Text = "ON";
			this.onToolStripMenuItem.Click += new EventHandler (this.onToolStripMenuItem_Click);
			this.oFFToolStripMenuItem.Name = "oFFToolStripMenuItem";
			this.oFFToolStripMenuItem.Size = new System.Drawing.Size (94, 22);
			this.oFFToolStripMenuItem.Text = "OFF";
			this.oFFToolStripMenuItem.Click += new EventHandler (this.oFFToolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size (156, 6);
			this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
			this.exitToolStripMenuItem2.Size = new System.Drawing.Size (159, 22);
			this.exitToolStripMenuItem2.Text = "&Exit";
			this.exitToolStripMenuItem2.Click += new EventHandler (this.exitToolStripMenuItem2_Click);
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size (48, 20);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new EventHandler (this.aboutToolStripMenuItem_Click);
			this.gameToolStripMenuItem1.Name = "gameToolStripMenuItem1";
			this.gameToolStripMenuItem1.Size = new System.Drawing.Size (46, 20);
			this.gameToolStripMenuItem1.Text = "&Game";
			this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
			this.newGameToolStripMenuItem1.Size = new System.Drawing.Size (152, 22);
			this.newGameToolStripMenuItem1.Text = "&New Game";
			this.reToolStripMenuItem.Name = "reToolStripMenuItem";
			this.reToolStripMenuItem.Size = new System.Drawing.Size (152, 22);
			this.reToolStripMenuItem.Text = "&Restart Game";
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size (152, 22);
			this.exitToolStripMenuItem1.Text = "Exit";
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size (152, 22);
			this.toolStripMenuItem1.Text = "&Sound";
			this.board.Image = ((Image) SnakeAndLadders.Properties.Resources.board);
			this.board.Location = new Point (-15, 85);
			this.board.Name = "board";
			this.board.Size = new System.Drawing.Size (654, 580);
			this.board.SizeMode = PictureBoxSizeMode.AutoSize;
			this.board.TabIndex = 0;
			this.board.TabStop = false;
			this.board.Paint += new PaintEventHandler (this.board_Paint);
			base.AutoScaleDimensions = new SizeF (6F, 13F);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.ClientSize = new System.Drawing.Size (1006, 648);
			base.Controls.Add (((Control) this.axMediaPlayer2));
			base.Controls.Add (((Control) this.axMediaPlayer1));
			base.Controls.Add (((Control) this.GroupPlayesStatus));
			base.Controls.Add (((Control) this.GroupPlayerOption));
			base.Controls.Add (((Control) this.board));
			base.Controls.Add (((Control) this.menuStrip1));
			base.Icon = ((System.Drawing.Icon) componentResourceManager1.GetObject ("$this.Icon"));
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			base.Name = "MainBoard";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Snakes And Ladders";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler (this.MainBoard_Load);
			this.GroupPlayerOption.ResumeLayout (false);
			this.GroupPlayerOption.PerformLayout ();
			((ISupportInitialize) this.pictureBox1).EndInit ();
			this.GroupPlayesStatus.ResumeLayout (false);
			this.GroupPlayesStatus.PerformLayout ();
			((ISupportInitialize) this.PicBoxArrow4).EndInit ();
			((ISupportInitialize) this.PicBoxArrow3).EndInit ();
			((ISupportInitialize) this.PicBoxArrow2).EndInit ();
			((ISupportInitialize) this.P1randomPicBox).EndInit ();
			((ISupportInitialize) this.PicBoxArrow1).EndInit ();
			((ISupportInitialize) this.P4randomPicBox).EndInit ();
			((ISupportInitialize) this.P3randomPicBox).EndInit ();
			((ISupportInitialize) this.P2randomPicBox).EndInit ();
			((ISupportInitialize) this.axMediaPlayer1).EndInit ();
			((ISupportInitialize) this.axMediaPlayer2).EndInit ();
			this.menuStrip1.ResumeLayout (false);
			this.menuStrip1.PerformLayout ();
			((ISupportInitialize) this.board).EndInit ();
			base.ResumeLayout (false);
			base.PerformLayout ();
		}
		
		private void MainBoard_Load (object sender, EventArgs e)
		{
			int i1;
			this.axMediaPlayer1.FileName = "music.mid";
			this.restartGameToolStripMenuItem1.Enabled = false;
			for (i1 = 0; (i1 < 4); i1++)
			{
				int i2 = this.Beads.Add (new GameBeads (i1, 27, ((int) (460 - (i1 * 45)))));
			}
			this.WinnerFlag[0] = false;
			this.WinnerFlag[1] = false;
			this.WinnerFlag[2] = false;
			this.WinnerFlag[3] = false;
			this.ranking[0] = "-";
			this.ranking[1] = "-";
			this.ranking[2] = "-";
			this.ranking[3] = "-";
		}
		
		private void newGameToolStripMenuItem_Click (object sender, EventArgs e)
		{
			this.GroupPlayerOption.Enabled = true;
		}
		
		private void newGameToolStripMenuItem2_Click (object sender, EventArgs e)
		{
			int i1;
			this.axMediaPlayer1.FileName = "music.mid";
			this.cmbNoOfPlayers.Text = "2";
			this.restartGameToolStripMenuItem1.Enabled = false;
			for (i1 = 0; (i1 < 4); i1++)
			{
				((GameBeads) this.Beads[i1]).Clone (42, 42);
			}
			for (i1 = 0; (i1 < 4); i1++)
			{
				((GameBeads) this.Beads[i1]).SetLocation (27, ((int) (460 - (i1 * 45))));
			}
			this.WinnerFlag[0] = false;
			this.WinnerFlag[1] = false;
			this.WinnerFlag[2] = false;
			this.WinnerFlag[3] = false;
			this.ranking[0] = "-";
			this.ranking[1] = "-";
			this.ranking[2] = "-";
			this.ranking[3] = "-";
			this.index = -1;
			this.board.Invalidate ();
			this.txtPlayer1.Text = "";
			this.txtPlayer2.Text = "";
			this.txtPlayer3.Text = "";
			this.txtPlayer4.Text = "";
			this.txtDoPlayer1.Visible = false;
			this.txtDoPlayer2.Visible = false;
			this.txtDoPlayer3.Visible = false;
			this.txtDoPlayer4.Visible = false;
			this.P1randomPicBox.Visible = false;
			this.P2randomPicBox.Visible = false;
			this.P3randomPicBox.Visible = false;
			this.P4randomPicBox.Visible = false;
			this.LblP1.Enabled = true;
			this.LblP2.Enabled = true;
			this.LblP3.Enabled = false;
			this.LblP4.Enabled = false;
			this.LblStatusP1.Visible = false;
			this.LblStatusP2.Visible = false;
			this.LblStatusP3.Visible = false;
			this.LblStatusP4.Visible = false;
			this.LblStatusP1.Text = "IDLE";
			this.LblStatusP2.Text = "IDLE";
			this.LblStatusP3.Text = "IDLE";
			this.LblStatusP4.Text = "IDLE";
			this.LblPlayer1.Visible = false;
			this.LblPlayer2.Visible = false;
			this.LblPlayer3.Visible = false;
			this.LblPlayer4.Visible = false;
			this.PicBoxArrow1.Visible = false;
			this.PicBoxArrow2.Visible = false;
			this.PicBoxArrow3.Visible = false;
			this.PicBoxArrow4.Visible = false;
			this.start = true;
			this.ShowTimer.Enabled = false;
			this.HideTimer.Enabled = false;
			this.ShowSnakeMovingTimer.Enabled = false;
			this.HideSnakeMovingTimer.Enabled = false;
			this.ShowLadderMovingTimer.Enabled = false;
			this.HideLadderMovingTimer.Enabled = false;
			this.btnStart.Enabled = true;
			this.checkBoxP2.Enabled = true;
			this.checkBoxP3.Enabled = false;
			this.checkBoxP4.Enabled = false;
			this.txtPlayer1.Enabled = true;
			this.txtPlayer2.Enabled = true;
			this.checkBoxP2.Checked = true;
			this.cmbNoOfPlayers.Enabled = true;
			this.game.Restart ();
			this.Dice.Restart ();
		}
		
		private void oFFToolStripMenuItem_Click (object sender, EventArgs e)
		{
			this.oFFToolStripMenuItem.Checked = true;
			this.onToolStripMenuItem.Checked = false;
			this.SoundEnable = false;
			this.axMediaPlayer1.Pause ();
		}
		
		private void onToolStripMenuItem_Click (object sender, EventArgs e)
		{
			this.oFFToolStripMenuItem.Checked = false;
			this.onToolStripMenuItem.Checked = true;
			this.axMediaPlayer1.Play ();
		}
		
		private void pictureBox1_Click (object sender, EventArgs e)
		{
		}
		
		private void restartGameToolStripMenuItem1_Click (object sender, EventArgs e)
		{
			int i1;
			this.game.Restart ();
			this.Dice.Restart ();
			for (i1 = 0; (i1 < int.Parse (this.cmbNoOfPlayers.Text)); i1++)
			{
				((GameBeads) this.Beads[i1]).Clone (42, 42);
			}
			for (i1 = 0; (i1 < int.Parse (this.cmbNoOfPlayers.Text)); i1++)
			{
				((GameBeads) this.Beads[i1]).SetLocation (27, ((int) (460 - (i1 * 45))));
			}
			this.board.Invalidate ();
			this.index = -1;
			this.WinnerFlag[0] = false;
			this.WinnerFlag[1] = false;
			this.WinnerFlag[2] = false;
			this.WinnerFlag[3] = false;
			this.ranking[0] = "-";
			this.ranking[1] = "-";
			this.ranking[2] = "-";
			this.ranking[3] = "-";
			this.P1randomPicBox.Image = ((Image) null);
			this.P2randomPicBox.Image = ((Image) null);
			this.P3randomPicBox.Image = ((Image) null);
			this.P4randomPicBox.Image = ((Image) null);
			this.LblStatusP1.Text = "IDLE";
			this.LblStatusP2.Text = "IDLE";
			this.LblStatusP3.Text = "IDLE";
			this.LblStatusP4.Text = "IDLE";
			this.PlayerShouldMoved = 0;
			this.ShowMovingArrow (this.PlayerShouldMoved);
			this.start = true;
			this.ShowTimer.Enabled = false;
			this.HideTimer.Enabled = false;
			this.ShowSnakeMovingTimer.Enabled = false;
			this.HideSnakeMovingTimer.Enabled = false;
			this.ShowLadderMovingTimer.Enabled = false;
			this.HideLadderMovingTimer.Enabled = false;
		}
		
		public void ShowMovingArrow (int PlayerNumber)
		{
			switch (PlayerNumber)
			{
				case 0:
				
				{
						this.txtDoPlayer1.Enabled = true;
						bool b1 = this.txtDoPlayer1.Focus ();
						this.txtDoPlayer2.Enabled = false;
						this.txtDoPlayer3.Enabled = false;
						this.txtDoPlayer4.Enabled = false;
						this.PicBoxArrow1.Visible = true;
						this.PicBoxArrow2.Visible = false;
						this.PicBoxArrow3.Visible = false;
						this.PicBoxArrow4.Visible = false;
						return;
				}
				case 1:
				
				{
						this.txtDoPlayer1.Enabled = false;
						this.txtDoPlayer2.Enabled = true;
						bool b2 = this.txtDoPlayer2.Focus ();
						this.txtDoPlayer3.Enabled = false;
						this.txtDoPlayer4.Enabled = false;
						this.PicBoxArrow1.Visible = false;
						this.PicBoxArrow2.Visible = true;
						this.PicBoxArrow3.Visible = false;
						this.PicBoxArrow4.Visible = false;
						return;
				}
				case 2:
				
				{
						this.txtDoPlayer1.Enabled = false;
						this.txtDoPlayer2.Enabled = false;
						this.txtDoPlayer3.Enabled = true;
						bool b3 = this.txtDoPlayer3.Focus ();
						this.txtDoPlayer4.Enabled = false;
						this.PicBoxArrow1.Visible = false;
						this.PicBoxArrow2.Visible = false;
						this.PicBoxArrow3.Visible = true;
						this.PicBoxArrow4.Visible = false;
						return;
				}
				case 3:
				
				{
						this.txtDoPlayer1.Enabled = false;
						this.txtDoPlayer2.Enabled = false;
						this.txtDoPlayer3.Enabled = false;
						this.txtDoPlayer4.Enabled = true;
						bool b4 = this.txtDoPlayer4.Focus ();
						this.PicBoxArrow1.Visible = false;
						this.PicBoxArrow2.Visible = false;
						this.PicBoxArrow3.Visible = false;
						this.PicBoxArrow4.Visible = true;
						return;
				}
			}
		}
		
		private void ShowTimer_Tick (object sender, EventArgs e)
		{
			if (this.start)
			{
				this.num = 4;
				this.X = (((GameBeads)this.Beads[this.Player]).GetBeadX(targetRectangle) - 1);
				this.Y = (((GameBeads) this.Beads[this.Player]).GetBeadY () - 1);
				this.start = false;
			}
			((GameBeads) this.Beads[this.Player]).Clone (this.num, this.num);
			((GameBeads) this.Beads[this.Player]).SetLocation (this.X, this.Y);
			this.board.Invalidate ();
			this.num += 2;
			this.X--;
			this.Y--;
			if (this.num != 44)
			{
				return;
			}
			this.start = true;
			this.ShowTimer.Enabled = false;
			this.HideTimer.Enabled = false;
			this.HideSnakeMovingTimer.Enabled = true;
		}
		
		private void timer_Tick (object sender, EventArgs e)
		{
		}
		
		private void timer1_Tick (object sender, EventArgs e)
		{
			if (this.start)
			{
				this.num = 4;
				this.X = (((GameBeads)this.Beads[this.Player]).GetBeadX(targetRectangle) - 1);
				this.Y = (((GameBeads) this.Beads[this.Player]).GetBeadY () - 1);
				this.start = false;
			}
			((GameBeads) this.Beads[this.Player]).Clone (this.num, this.num);
			((GameBeads) this.Beads[this.Player]).SetLocation (this.X, this.Y);
			this.board.Invalidate ();
			this.num += 2;
			this.X--;
			this.Y--;
			if (this.num != 44)
			{
				return;
			}
			this.start = true;
			this.ShowSnakeMovingTimer.Enabled = false;
			this.HideSnakeMovingTimer.Enabled = false;
			this.HideLadderMovingTimer.Enabled = true;
		}
		
		private void timer2_Tick (object sender, EventArgs e)
		{
			if (this.start)
			{
				if (this.snake.status (this.game.GetLocation (this.Player)) != 0)
				{
					this.start = false;
					if (this.SoundEnable)
					{
						this.axMediaPlayer2.FileName = "SNAKE.WAV";
					}
				}
				else
				{
					this.HideSnakeMovingTimer.Enabled = false;
					this.HideLadderMovingTimer.Enabled = true;
				}
				this.num = 42;
				this.X = ((GameBeads)this.Beads[this.Player]).GetBeadX(targetRectangle);
				this.Y = ((GameBeads) this.Beads[this.Player]).GetBeadY ();
			}
			((GameBeads) this.Beads[this.Player]).Clone (this.num, this.num);
			((GameBeads) this.Beads[this.Player]).SetLocation (this.X, this.Y);
			this.board.Invalidate ();
			this.num -= 2;
			this.X++;
			this.Y++;
			if (this.num != 0)
			{
				return;
			}
			this.start = true;
			this.HideSnakeMovingTimer.Enabled = false;
			this.game.Play (((GameBeads) this.Beads[this.Player]), this.snake.status (this.game.GetLocation (this.Player)), this.Player, false);
			this.board.Invalidate ();
			this.ShowSnakeMovingTimer.Enabled = true;
		}
		
		private void timer3_Tick (object sender, EventArgs e)
		{
			if (this.start)
			{
				this.num = 4;
				this.X = (((GameBeads)this.Beads[this.Player]).GetBeadX(targetRectangle) - 1);
				this.Y = (((GameBeads) this.Beads[this.Player]).GetBeadY () - 1);
				this.start = false;
			}
			((GameBeads) this.Beads[this.Player]).Clone (this.num, this.num);
			((GameBeads) this.Beads[this.Player]).SetLocation (this.X, this.Y);
			this.board.Invalidate ();
			this.num += 2;
			this.X--;
			this.Y--;
			if (this.num != 44)
			{
				return;
			}
			this.start = true;
			this.ShowLadderMovingTimer.Enabled = false;
			this.HideLadderMovingTimer.Enabled = false;
			if (this.WinnerStatus ())
			{
				return;
			}
			if (this.ActiveButton == this.txtDoPlayer1)
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (this.DiceNum == 6)
				{
					this.axMediaPlayer2.FileName = "reward.mid";
					this.PlayerShouldMoved = 0;
					this.ShowMovingArrow (this.PlayerShouldMoved);
					this.LblStatusP1.Text = "REWARD!";
				}
				if (this.checkBoxP2.Checked && (this.PlayerShouldMoved == 1))
				{
					this.txtDoPlayer2.PerformClick ();
				}
				if ((! this.game.IsWinner (0)) || (this.PlayerShouldMoved != 0))
				{
					return;
				}
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.checkBoxP2.Checked)
				{
					return;
				}
				this.txtDoPlayer2.PerformClick ();
				return;
			}
			if (this.ActiveButton == this.txtDoPlayer2)
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (this.DiceNum == 6)
				{
					this.axMediaPlayer2.FileName = "reward.mid";
					this.PlayerShouldMoved = 1;
					this.ShowMovingArrow (this.PlayerShouldMoved);
					this.LblStatusP2.Text = "REWARD!";
					if (this.checkBoxP2.Checked)
					{
						this.txtDoPlayer2.PerformClick ();
					}
				}
				if (this.checkBoxP3.Checked && (this.PlayerShouldMoved == 2))
				{
					this.txtDoPlayer3.PerformClick ();
				}
				if ((! this.game.IsWinner (0)) || (this.PlayerShouldMoved != 0))
				{
					return;
				}
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.checkBoxP2.Checked)
				{
					return;
				}
				this.txtDoPlayer2.PerformClick ();
				return;
			}
			if (this.ActiveButton == this.txtDoPlayer3)
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (this.DiceNum == 6)
				{
					this.axMediaPlayer2.FileName = "reward.mid";
					this.LblStatusP2.Text = "REWARD!";
					this.PlayerShouldMoved = 2;
					this.ShowMovingArrow (this.PlayerShouldMoved);
					if (this.checkBoxP3.Checked)
					{
						this.txtDoPlayer3.PerformClick ();
					}
				}
				if (this.checkBoxP4.Checked && (this.PlayerShouldMoved == 3))
				{
					this.txtDoPlayer4.PerformClick ();
				}
				if ((! this.game.IsWinner (0)) || (this.PlayerShouldMoved != 0))
				{
					return;
				}
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.checkBoxP2.Checked)
				{
					return;
				}
				this.txtDoPlayer2.PerformClick ();
				return;
			}
			if (this.ActiveButton != this.txtDoPlayer4)
			{
				return;
			}
			this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
			this.ShowMovingArrow (this.PlayerShouldMoved);
			if (this.DiceNum == 6)
			{
				this.axMediaPlayer2.FileName = "reward.mid";
				this.LblStatusP2.Text = "REWARD!";
				this.PlayerShouldMoved = 3;
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (this.checkBoxP4.Checked)
				{
					this.txtDoPlayer4.PerformClick ();
				}
			}
			if ((! this.game.IsWinner (0)) || (this.PlayerShouldMoved != 0))
			{
				return;
			}
			this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
			this.ShowMovingArrow (this.PlayerShouldMoved);
			if (! this.checkBoxP2.Checked)
			{
				return;
			}
			this.txtDoPlayer2.PerformClick ();
		}
		
		private void timer4_Tick (object sender, EventArgs e)
		{
			if (this.start)
			{
				if (this.ladder.status (this.game.GetLocation (this.Player)) != 0)
				{
					this.start = false;
					if (this.SoundEnable)
					{
						this.axMediaPlayer2.FileName = "LADDER.WAV";
					}
				}
				else
				{
					this.HideLadderMovingTimer.Enabled = false;
					this.ActiveButton.Enabled = true;
					if (this.WinnerStatus ())
					{
						return;
					}
					if (this.ActiveButton == this.txtDoPlayer1)
					{
						this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
						this.ShowMovingArrow (this.PlayerShouldMoved);
						if (this.DiceNum == 6)
						{
							if (this.SoundEnable)
							{
								this.axMediaPlayer2.FileName = "reward.mid";
							}
							this.PlayerShouldMoved = 0;
							this.ShowMovingArrow (this.PlayerShouldMoved);
							this.LblStatusP1.Text = "REWARD!";
						}
						if (this.checkBoxP2.Checked && (this.PlayerShouldMoved == 1))
						{
							this.txtDoPlayer2.PerformClick ();
						}
						if (this.game.IsWinner (0) && (this.PlayerShouldMoved == 0))
						{
							this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
							this.ShowMovingArrow (this.PlayerShouldMoved);
							if (! this.checkBoxP2.Checked)
							{
								return;
							}
							this.txtDoPlayer2.PerformClick ();
						}
					}
					else if (this.ActiveButton == this.txtDoPlayer2)
					{
						this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
						this.ShowMovingArrow (this.PlayerShouldMoved);
						if (this.DiceNum == 6)
						{
							this.axMediaPlayer2.FileName = "reward.mid";
							this.PlayerShouldMoved = 1;
							this.ShowMovingArrow (this.PlayerShouldMoved);
							this.LblStatusP2.Text = "REWARD!";
							if (this.checkBoxP2.Checked)
							{
								this.txtDoPlayer2.PerformClick ();
							}
						}
						if (this.checkBoxP3.Checked && (this.PlayerShouldMoved == 2))
						{
							this.txtDoPlayer3.PerformClick ();
						}
						if (this.game.IsWinner (0) && (this.PlayerShouldMoved == 0))
						{
							this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
							this.ShowMovingArrow (this.PlayerShouldMoved);
							if (! this.checkBoxP2.Checked)
							{
								return;
							}
							this.txtDoPlayer2.PerformClick ();
						}
					}
					else if (this.ActiveButton == this.txtDoPlayer3)
					{
						this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
						this.ShowMovingArrow (this.PlayerShouldMoved);
						if (this.DiceNum == 6)
						{
							this.axMediaPlayer2.FileName = "reward.mid";
							this.LblStatusP2.Text = "REWARD!";
							this.PlayerShouldMoved = 2;
							this.ShowMovingArrow (this.PlayerShouldMoved);
							if (this.checkBoxP3.Checked)
							{
								this.txtDoPlayer3.PerformClick ();
							}
						}
						if (this.checkBoxP4.Checked && (this.PlayerShouldMoved == 3))
						{
							this.txtDoPlayer4.PerformClick ();
						}
						if (this.game.IsWinner (0) && (this.PlayerShouldMoved == 0))
						{
							this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
							this.ShowMovingArrow (this.PlayerShouldMoved);
							if (! this.checkBoxP2.Checked)
							{
								return;
							}
							this.txtDoPlayer2.PerformClick ();
						}
					}
					else if (this.ActiveButton == this.txtDoPlayer4)
					{
						this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
						this.ShowMovingArrow (this.PlayerShouldMoved);
						if (this.DiceNum == 6)
						{
							this.axMediaPlayer2.FileName = "reward.mid";
							this.LblStatusP2.Text = "REWARD!";
							this.PlayerShouldMoved = 3;
							this.ShowMovingArrow (this.PlayerShouldMoved);
							if (this.checkBoxP4.Checked)
							{
								this.txtDoPlayer4.PerformClick ();
							}
						}
						if (this.game.IsWinner (0) && (this.PlayerShouldMoved == 0))
						{
							this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
							this.ShowMovingArrow (this.PlayerShouldMoved);
							if (! this.checkBoxP2.Checked)
							{
								return;
							}
							this.txtDoPlayer2.PerformClick ();
						}
					}
				}
				this.num = 42;
				this.X = ((GameBeads)this.Beads[this.Player]).GetBeadX(targetRectangle);
				this.Y = ((GameBeads) this.Beads[this.Player]).GetBeadY ();
			}
			((GameBeads) this.Beads[this.Player]).Clone (this.num, this.num);
			((GameBeads) this.Beads[this.Player]).SetLocation (this.X, this.Y);
			this.board.Invalidate ();
			this.num -= 2;
			this.X++;
			this.Y++;
			if (this.num != 0)
			{
				return;
			}
			this.start = true;
			this.HideLadderMovingTimer.Enabled = false;
			this.game.Play (((GameBeads) this.Beads[this.Player]), this.ladder.status (this.game.GetLocation (this.Player)), this.Player, true);
			this.board.Invalidate ();
			this.ShowLadderMovingTimer.Enabled = true;
		}
		
		private void toolStripMenuItem2_Click_1 (object sender, EventArgs e)
		{
		}
		
		private void txtDo_Click (object sender, EventArgs e)
		{
			if (! this.Dice.CanStartMoving (0))
			{
				this.P1randomPicBox.Image = Image.FromFile (this.Dice.next (0));
			}
			if (! this.Dice.CanStartMoving (0))
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.checkBoxP2.Checked)
				{
					return;
				}
				this.txtDoPlayer2.PerformClick ();
				return;
			}
			this.LblStatusP1.Text = "";
			this.Player = this.PlayerShouldMoved;
			this.ActiveButton = this.txtDoPlayer1;
			if (this.game.IsWinner (this.Player))
			{
				this.P1randomPicBox.Image = ((Image) null);
			}
			else
			{
				this.P1randomPicBox.Image = Image.FromFile (this.Dice.next (this.Player));
			}
			this.DiceNum = this.Dice.GetRand ();
			if (this.game.IsLarggerThan100 (this.DiceNum, this.Player) || this.game.IsWinner (this.Player))
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if ((this.PlayerShouldMoved == 0) && (! this.game.IsWinner (0)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 0) && this.game.IsWinner (0))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
				}
				if ((this.checkBoxP2.Checked && (this.PlayerShouldMoved == 1)) && (! this.game.IsWinner (1)))
				{
					this.txtDoPlayer2.PerformClick ();
					return;
				}
				if (((! this.checkBoxP2.Checked) && (this.PlayerShouldMoved == 1)) && (! this.game.IsWinner (1)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 1) && this.game.IsWinner (1))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
				}
				if ((this.checkBoxP3.Checked && (this.PlayerShouldMoved == 2)) && (! this.game.IsWinner (2)))
				{
					this.txtDoPlayer3.PerformClick ();
					return;
				}
				if (((! this.checkBoxP3.Checked) && (this.PlayerShouldMoved == 2)) && (! this.game.IsWinner (2)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 2) && this.game.IsWinner (2))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
					if ((this.PlayerShouldMoved == 0) && (! this.game.IsWinner (0)))
					{
						return;
					}
					if ((this.PlayerShouldMoved == 0) && this.game.IsWinner (0))
					{
						this.txtDoPlayer1.PerformClick ();
					}
				}
				if ((this.checkBoxP4.Checked && (this.PlayerShouldMoved == 3)) && (! this.game.IsWinner (3)))
				{
					this.txtDoPlayer4.PerformClick ();
					return;
				}
				if (((! this.checkBoxP4.Checked) && (this.PlayerShouldMoved == 3)) && (! this.game.IsWinner (3)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 3) && this.game.IsWinner (3))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					if (this.game.IsWinner (0))
					{
						this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
						this.ShowMovingArrow (this.PlayerShouldMoved);
						if (! this.checkBoxP2.Checked)
						{
							return;
						}
						this.txtDoPlayer1.PerformClick ();
					}
					this.ShowMovingArrow (this.PlayerShouldMoved);
					return;
				}
			}
			this.HideTimer.Enabled = true;
		}
		
		private void txtDoPlayer2_Click (object sender, EventArgs e)
		{
			if (! this.Dice.CanStartMoving (1))
			{
				this.P2randomPicBox.Image = Image.FromFile (this.Dice.next (1));
			}
			if (! this.Dice.CanStartMoving (1))
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (this.checkBoxP3.Checked && (this.PlayerShouldMoved == 2))
				{
					this.txtDoPlayer3.PerformClick ();
				}
				if ((! this.game.IsWinner (0)) || (this.PlayerShouldMoved != 0))
				{
					return;
				}
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.checkBoxP2.Checked)
				{
					return;
				}
				this.txtDoPlayer1.PerformClick ();
				return;
			}
			this.LblStatusP2.Text = "";
			this.Player = this.PlayerShouldMoved;
			this.ActiveButton = this.txtDoPlayer2;
			if (this.game.IsWinner (this.Player))
			{
				this.P2randomPicBox.Image = ((Image) null);
			}
			else
			{
				this.P2randomPicBox.Image = Image.FromFile (this.Dice.next (this.Player));
			}
			this.DiceNum = this.Dice.GetRand ();
			if (this.game.IsLarggerThan100 (this.DiceNum, this.Player) || this.game.IsWinner (this.Player))
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if ((this.PlayerShouldMoved == 0) && (! this.game.IsWinner (0)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 0) && this.game.IsWinner (0))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
				}
				if ((this.checkBoxP2.Checked && (this.PlayerShouldMoved == 1)) && (! this.game.IsWinner (1)))
				{
					this.txtDoPlayer2.PerformClick ();
					return;
				}
				if (((! this.checkBoxP2.Checked) && (this.PlayerShouldMoved == 1)) && (! this.game.IsWinner (1)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 1) && this.game.IsWinner (1))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
				}
				if ((this.checkBoxP3.Checked && (this.PlayerShouldMoved == 2)) && (! this.game.IsWinner (2)))
				{
					this.txtDoPlayer3.PerformClick ();
					return;
				}
				if (((! this.checkBoxP3.Checked) && (this.PlayerShouldMoved == 2)) && (! this.game.IsWinner (2)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 2) && this.game.IsWinner (2))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
					if ((this.PlayerShouldMoved == 0) && (! this.game.IsWinner (0)))
					{
						return;
					}
					if ((this.PlayerShouldMoved == 0) && this.game.IsWinner (0))
					{
						this.txtDoPlayer1.PerformClick ();
					}
				}
				if ((this.checkBoxP4.Checked && (this.PlayerShouldMoved == 3)) && (! this.game.IsWinner (3)))
				{
					this.txtDoPlayer4.PerformClick ();
					return;
				}
				if (((! this.checkBoxP4.Checked) && (this.PlayerShouldMoved == 3)) && (! this.game.IsWinner (3)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 3) && this.game.IsWinner (3))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					if (this.game.IsWinner (0))
					{
						this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
						this.ShowMovingArrow (this.PlayerShouldMoved);
						if (! this.checkBoxP2.Checked)
						{
							return;
						}
						this.txtDoPlayer2.PerformClick ();
					}
					this.ShowMovingArrow (this.PlayerShouldMoved);
					return;
				}
			}
			this.HideTimer.Enabled = true;
		}
		
		private void txtDoPlayer3_Click (object sender, EventArgs e)
		{
			if (! this.Dice.CanStartMoving (2))
			{
				this.P3randomPicBox.Image = Image.FromFile (this.Dice.next (2));
			}
			if (! this.Dice.CanStartMoving (2))
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (this.checkBoxP4.Checked && (this.PlayerShouldMoved == 3))
				{
					this.txtDoPlayer4.PerformClick ();
				}
				if ((! this.game.IsWinner (0)) || (this.PlayerShouldMoved != 0))
				{
					return;
				}
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.checkBoxP2.Checked)
				{
					return;
				}
				this.txtDoPlayer2.PerformClick ();
				return;
			}
			this.LblStatusP3.Text = "";
			this.Player = this.PlayerShouldMoved;
			this.ActiveButton = this.txtDoPlayer3;
			if (this.game.IsWinner (this.Player))
			{
				this.P3randomPicBox.Image = ((Image) null);
			}
			else
			{
				this.P3randomPicBox.Image = Image.FromFile (this.Dice.next (this.Player));
			}
			this.DiceNum = this.Dice.GetRand ();
			if (this.game.IsLarggerThan100 (this.DiceNum, this.Player) || this.game.IsWinner (this.Player))
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if ((this.PlayerShouldMoved == 0) && (! this.game.IsWinner (0)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 0) && this.game.IsWinner (0))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
				}
				if ((this.checkBoxP2.Checked && (this.PlayerShouldMoved == 1)) && (! this.game.IsWinner (1)))
				{
					this.txtDoPlayer2.PerformClick ();
					return;
				}
				if (((! this.checkBoxP2.Checked) && (this.PlayerShouldMoved == 1)) && (! this.game.IsWinner (1)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 1) && this.game.IsWinner (1))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
				}
				if ((this.checkBoxP3.Checked && (this.PlayerShouldMoved == 2)) && (! this.game.IsWinner (2)))
				{
					this.txtDoPlayer3.PerformClick ();
					return;
				}
				if (((! this.checkBoxP3.Checked) && (this.PlayerShouldMoved == 2)) && (! this.game.IsWinner (2)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 2) && this.game.IsWinner (2))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
					if ((this.PlayerShouldMoved == 0) && (! this.game.IsWinner (0)))
					{
						return;
					}
					if ((this.PlayerShouldMoved == 0) && this.game.IsWinner (0))
					{
						this.txtDoPlayer1.PerformClick ();
					}
				}
				if ((this.checkBoxP4.Checked && (this.PlayerShouldMoved == 3)) && (! this.game.IsWinner (3)))
				{
					this.txtDoPlayer4.PerformClick ();
					return;
				}
				if (((! this.checkBoxP4.Checked) && (this.PlayerShouldMoved == 3)) && (! this.game.IsWinner (3)))
				{
					return;
				}
				if ((this.PlayerShouldMoved == 3) && this.game.IsWinner (3))
				{
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
					if (! this.game.IsWinner (0))
					{
						return;
					}
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
					if (! this.checkBoxP2.Checked)
					{
						return;
					}
					this.txtDoPlayer1.PerformClick ();
					return;
				}
			}
			this.HideTimer.Enabled = true;
		}
		
		private void txtDoPlayer4_Click (object sender, EventArgs e)
		{
			if (! this.Dice.CanStartMoving (3))
			{
				this.P4randomPicBox.Image = Image.FromFile (this.Dice.next (3));
			}
			if (! this.Dice.CanStartMoving (3))
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.game.IsWinner (this.PlayerShouldMoved))
				{
					if ((! this.game.IsWinner (0)) || (this.PlayerShouldMoved != 0))
					{
						return;
					}
					this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
					this.ShowMovingArrow (this.PlayerShouldMoved);
					if (! this.checkBoxP2.Checked)
					{
						return;
					}
					this.txtDoPlayer2.PerformClick ();
					return;
				}
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.checkBoxP2.Checked)
				{
					return;
				}
				this.txtDoPlayer2.PerformClick ();
				return;
			}
			this.LblStatusP4.Text = "";
			this.Player = this.PlayerShouldMoved;
			this.ActiveButton = this.txtDoPlayer4;
			if (this.game.IsWinner (this.Player))
			{
				this.P4randomPicBox.Image = ((Image) null);
			}
			else
			{
				this.P4randomPicBox.Image = Image.FromFile (this.Dice.next (this.Player));
			}
			this.DiceNum = this.Dice.GetRand ();
			if (this.game.IsLarggerThan100 (this.DiceNum, this.Player) || this.game.IsWinner (this.Player))
			{
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.game.IsWinner (this.PlayerShouldMoved))
				{
					return;
				}
				this.PlayerShouldMoved = ((this.PlayerShouldMoved + 1) % int.Parse (this.cmbNoOfPlayers.Text));
				this.ShowMovingArrow (this.PlayerShouldMoved);
				if (! this.checkBoxP2.Checked)
				{
					return;
				}
				this.txtDoPlayer2.PerformClick ();
				return;
			}
			this.HideTimer.Enabled = true;
		}
		
		private bool WinnerStatus ()
		{
			int i1;
			int i2;
			int i3;
			string[] stringArray1;
			char char1 = this.cmbNoOfPlayers.Text[0];
			switch (char1)
			{
				case '2':
				
				{
						if (this.game.IsWinner (0) && (! this.WinnerFlag[0]))
						{
							this.index = (i2 = (this.index + 1));
							this.ranking[i2] = this.txtPlayer1.Text;
							this.WinnerFlag[0] = true;
							this.axMediaPlayer2.FileName = "WIN.WAV";
						}
						else if (this.game.IsWinner (1) && (! this.WinnerFlag[1]))
						{
							this.index = (i2 = (this.index + 1));
							this.ranking[i2] = this.txtPlayer2.Text;
							this.WinnerFlag[1] = true;
							this.axMediaPlayer2.FileName = "WIN.WAV";
						}
						switch (this.ranking[0])
						{
							case "-":
							
							{
									return false;
							}
							default:
							
							{
									for (i1 = 0; (i1 < int.Parse (this.cmbNoOfPlayers.Text)); i1++)
									{
										if (! this.game.IsWinner (i1))
										{
											i3 = i1;
											switch (i3)
											{
												case 0:
												
												{
														this.ranking[1] = this.txtPlayer1.Text;
														break;
												}
												case 1:
												
												{
														this.ranking[1] = this.txtPlayer2.Text;
														break;
												}
											}
										}
									}
									System.Windows.Forms.DialogResult dialogResult1 = MessageBox.Show (("****GAME OVER**** \n1-player: " + this.ranking[0] + "\n2-player: " + this.ranking[1]), "Notice");
									this.txtDoPlayer1.Enabled = false;
									this.txtDoPlayer2.Enabled = false;
									return true;
							}
						}
				}
				case '3':
				
				{
						if (this.game.IsWinner (0) && (! this.WinnerFlag[0]))
						{
							this.axMediaPlayer2.FileName = "WIN.WAV";
							this.index = (i2 = (this.index + 1));
							this.ranking[i2] = this.txtPlayer1.Text;
							this.WinnerFlag[0] = true;
							stringArray1 = new string[] { "1-player: ", this.ranking[0], "\n2-player: ", this.ranking[1], "\n3-player: ", this.ranking[2] };
							System.Windows.Forms.DialogResult dialogResult2 = MessageBox.Show (string.Concat (stringArray1), "Notice");
						}
						else if (this.game.IsWinner (1) && (! this.WinnerFlag[1]))
						{
							this.axMediaPlayer2.FileName = "WIN.WAV";
							this.index = (i2 = (this.index + 1));
							this.ranking[i2] = this.txtPlayer2.Text;
							this.WinnerFlag[1] = true;
							stringArray1 = new string[] { "1-player: ", this.ranking[0], "\n2-player: ", this.ranking[1], "\n3-player: ", this.ranking[2] };
							System.Windows.Forms.DialogResult dialogResult3 = MessageBox.Show (string.Concat (stringArray1), "Notice");
						}
						else if (this.game.IsWinner (2) && (! this.WinnerFlag[2]))
						{
							this.axMediaPlayer2.FileName = "WIN.WAV";
							this.index = (i2 = (this.index + 1));
							this.ranking[i2] = this.txtPlayer3.Text;
							this.WinnerFlag[2] = true;
							stringArray1 = new string[] { "1-player: ", this.ranking[0], "\n2-player: ", this.ranking[1], "\n3-player: ", this.ranking[2] };
							System.Windows.Forms.DialogResult dialogResult4 = MessageBox.Show (string.Concat (stringArray1), "Notice");
						}
						if ((this.ranking[0] != "-") && (this.ranking[1] != "-"))
						{
							for (i1 = 0; (i1 < int.Parse (this.cmbNoOfPlayers.Text)); i1++)
							{
								if (! this.game.IsWinner (i1))
								{
									i3 = i1;
									switch (i3)
									{
										case 0:
										
										{
												this.ranking[2] = this.txtPlayer1.Text;
												break;
										}
										case 1:
										
										{
												this.ranking[2] = this.txtPlayer2.Text;
												break;
										}
										case 2:
										
										{
												this.ranking[2] = this.txtPlayer3.Text;
												break;
										}
									}
								}
							}
							this.axMediaPlayer2.FileName = "WIN.WAV";
							stringArray1 = new string[] { "****GAME OVER**** \n1-player: ", this.ranking[0], "\n2-player: ", this.ranking[1], "\n3-player: ", this.ranking[2] };
							System.Windows.Forms.DialogResult dialogResult5 = MessageBox.Show (string.Concat (stringArray1), "Notice");
							this.txtDoPlayer1.Enabled = false;
							this.txtDoPlayer2.Enabled = false;
							this.txtDoPlayer3.Enabled = false;
							return true;
						}
						else
						{
							return false;
						}
				}
				case '4':
				
				{
						if (this.game.IsWinner (0) && (! this.WinnerFlag[0]))
						{
							this.axMediaPlayer2.FileName = "WIN.WAV";
							this.index = (i2 = (this.index + 1));
							this.ranking[i2] = this.txtPlayer1.Text;
							this.WinnerFlag[0] = true;
							stringArray1 = new string[] { "1-player: ", this.ranking[0], "\n2-player: ", this.ranking[1], "\n3-player: ", this.ranking[2], "\n4-player: ", this.ranking[3], "\n" };
							System.Windows.Forms.DialogResult dialogResult6 = MessageBox.Show (string.Concat (stringArray1), "Notice");
						}
						else if (this.game.IsWinner (1) && (! this.WinnerFlag[1]))
						{
							this.axMediaPlayer2.FileName = "WIN.WAV";
							this.index = (i2 = (this.index + 1));
							this.ranking[i2] = this.txtPlayer2.Text;
							this.WinnerFlag[1] = true;
							stringArray1 = new string[] { "1-player: ", this.ranking[0], "\n2-player: ", this.ranking[1], "\n3-player: ", this.ranking[2], "\n4-player: ", this.ranking[3], "\n" };
							System.Windows.Forms.DialogResult dialogResult7 = MessageBox.Show (string.Concat (stringArray1), "Notice");
						}
						else if (this.game.IsWinner (2) && (! this.WinnerFlag[2]))
						{
							this.axMediaPlayer2.FileName = "WIN.WAV";
							this.index = (i2 = (this.index + 1));
							this.ranking[i2] = this.txtPlayer3.Text;
							this.WinnerFlag[2] = true;
							stringArray1 = new string[] { "1-player: ", this.ranking[0], "\n2-player: ", this.ranking[1], "\n3-player: ", this.ranking[2], "\n4-player: ", this.ranking[3], "\n" };
							System.Windows.Forms.DialogResult dialogResult8 = MessageBox.Show (string.Concat (stringArray1), "Notice");
						}
						else if (this.game.IsWinner (3) && (! this.WinnerFlag[3]))
						{
							this.axMediaPlayer2.FileName = "WIN.WAV";
							this.index = (i2 = (this.index + 1));
							this.ranking[i2] = this.txtPlayer4.Text;
							this.WinnerFlag[3] = true;
							stringArray1 = new string[] { "1-player: ", this.ranking[0], "\n2-player: ", this.ranking[1], "\n3-player: ", this.ranking[2], "\n4-player: ", this.ranking[3], "\n" };
							System.Windows.Forms.DialogResult dialogResult9 = MessageBox.Show (string.Concat (stringArray1), "Notice");
						}
						if (((this.ranking[0] != "-") && (this.ranking[1] != "-")) && (this.ranking[2] != "-"))
						{
							for (i1 = 0; (i1 < int.Parse (this.cmbNoOfPlayers.Text)); i1++)
							{
								if (! this.game.IsWinner (i1))
								{
									i3 = i1;
									switch (i3)
									{
										case 0:
										
										{
												this.ranking[3] = this.txtPlayer1.Text;
												break;
										}
										case 1:
										
										{
												this.ranking[3] = this.txtPlayer2.Text;
												break;
										}
										case 2:
										
										{
												this.ranking[3] = this.txtPlayer3.Text;
												break;
										}
										case 3:
										
										{
												this.ranking[3] = this.txtPlayer4.Text;
												break;
										}
									}
								}
							}
							this.axMediaPlayer2.FileName = "WIN.WAV";
							stringArray1 = new string[] { "****GAME OVER**** \n1-player: ", this.ranking[0], "\n2-player: ", this.ranking[1], "\n3-player: ", this.ranking[2], "\n4-player: ", this.ranking[3], "\n" };
							System.Windows.Forms.DialogResult dialogResult10 = MessageBox.Show (string.Concat (stringArray1), "Notice");
							this.txtDoPlayer1.Enabled = false;
							this.txtDoPlayer2.Enabled = false;
							this.txtDoPlayer3.Enabled = false;
							this.txtDoPlayer4.Enabled = false;
							return true;
						}
						else
						{
							return false;
						}
				}
			}
			return false;
		}
		
		#endregion
	}
	
}

