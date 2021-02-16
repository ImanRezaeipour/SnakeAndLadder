/*
    ___  (
   /   \  )       __
  /// =( (     \ || `--.
  '/(__/==    -- ||    |
  _)  (   :    / ||_,--'
 |/ o )``.__      _[__]__
 |\   \.-' _(\\  |       |
 ||`.___,-'_-~~]_|_______|_____
 ||\.,-'  [____________________]
 ||_`.___.  ||.           \|||
 ||_______`.|| \        _ /|||
 |||     |||||. \    ,-|_|\|||
 |||     |||||\\_\__ |  \_/|||
-||+-----||+||+\\_,-'+-----||+--

Copyright © Iman System 2008
All Rights Reserved.
December 2008

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Snake_And_Ladder
{
    public partial class frmMain : Form
    {
        #region Variables...
        Random number = new Random();
        SoundPlayer player0 = new SoundPlayer();
        string path0 = ".\\Sound\\Music.wav";
        int[] left = new int[101];
        int[] top = new int[101];
        int[] start = new int[5];
        int[] cpu = new int[5];
        int iOld = 1;
        int star = 1;
        bool error = false;
        #endregion  Variables...
        #region Functions...
        private void Status(int OldLeft, int OldTop, int Number, string LeftName, string TopName)
        {
            #region Locations
            left[1] = 88; top[1] = 640;
            left[2] = 144; top[2] = 640;
            left[3] = 200; top[3] = 640;
            left[4] = 256; top[4] = 640;
            left[5] = 312; top[5] = 640;
            left[6] = 368; top[6] = 640;
            left[7] = 424; top[7] = 640;
            left[8] = 480; top[8] = 640;
            left[9] = 536; top[9] = 640;
            left[10] = 592; top[10] = 640;
            left[11] = 592; top[11] = 584;
            left[12] = 536; top[12] = 584;
            left[13] = 480; top[13] = 584;
            left[14] = 424; top[14] = 584;
            left[15] = 368; top[15] = 584;
            left[16] = 312; top[16] = 584;
            left[17] = 256; top[17] = 584;
            left[18] = 200; top[18] = 584;
            left[19] = 144; top[19] = 584;
            left[20] = 88; top[20] = 584;
            left[21] = 88; top[21] = 528;
            left[22] = 144; top[22] = 528;
            left[23] = 200; top[23] = 528;
            left[24] = 256; top[24] = 528;
            left[25] = 312; top[25] = 528;
            left[26] = 368; top[26] = 528;
            left[27] = 424; top[27] = 528;
            left[28] = 480; top[28] = 528;
            left[29] = 536; top[29] = 528;
            left[30] = 592; top[30] = 528;
            left[31] = 592; top[31] = 472;
            left[32] = 536; top[32] = 472;
            left[33] = 480; top[33] = 472;
            left[34] = 424; top[34] = 472;
            left[35] = 368; top[35] = 472;
            left[36] = 312; top[36] = 472;
            left[37] = 256; top[37] = 472;
            left[38] = 200; top[38] = 472;
            left[39] = 144; top[39] = 472;
            left[40] = 88; top[40] = 472;
            left[41] = 88; top[41] = 416;
            left[42] = 144; top[42] = 416;
            left[43] = 200; top[43] = 416;
            left[44] = 256; top[44] = 416;
            left[45] = 312; top[45] = 416;
            left[46] = 368; top[46] = 416;
            left[47] = 424; top[47] = 416;
            left[48] = 480; top[48] = 416;
            left[49] = 536; top[49] = 416;
            left[50] = 592; top[50] = 416;
            left[51] = 592; top[51] = 360;
            left[52] = 536; top[52] = 360;
            left[53] = 480; top[53] = 360;
            left[54] = 424; top[54] = 360;
            left[55] = 368; top[55] = 360;
            left[56] = 312; top[56] = 360;
            left[57] = 256; top[57] = 360;
            left[58] = 200; top[58] = 360;
            left[59] = 144; top[59] = 360;
            left[60] = 88; top[60] = 360;
            left[61] = 88; top[61] = 304;
            left[62] = 144; top[62] = 304;
            left[63] = 200; top[63] = 304;
            left[64] = 256; top[64] = 304;
            left[65] = 312; top[65] = 304;
            left[66] = 368; top[66] = 304;
            left[67] = 424; top[67] = 304;
            left[68] = 480; top[68] = 304;
            left[69] = 536; top[69] = 304;
            left[70] = 592; top[70] = 304;
            left[71] = 592; top[71] = 248;
            left[72] = 536; top[72] = 248;
            left[73] = 480; top[73] = 248;
            left[74] = 424; top[74] = 248;
            left[75] = 368; top[75] = 248;
            left[76] = 312; top[76] = 248;
            left[77] = 256; top[77] = 248;
            left[78] = 200; top[78] = 248;
            left[79] = 144; top[79] = 248;
            left[80] = 88; top[80] = 248;
            left[81] = 88; top[81] = 192;
            left[82] = 144; top[82] = 192;
            left[83] = 200; top[83] = 192;
            left[84] = 256; top[84] = 192;
            left[85] = 312; top[85] = 192;
            left[86] = 368; top[86] = 192;
            left[87] = 424; top[87] = 192;
            left[88] = 480; top[88] = 192;
            left[89] = 536; top[89] = 192;
            left[90] = 592; top[90] = 192;
            left[91] = 592; top[91] = 136;
            left[92] = 536; top[92] = 136;
            left[93] = 480; top[93] = 136;
            left[94] = 424; top[94] = 136;
            left[95] = 368; top[95] = 136;
            left[96] = 312; top[96] = 136;
            left[97] = 256; top[97] = 136;
            left[98] = 200; top[98] = 136;
            left[99] = 144; top[99] = 136;
            left[100] = 88; top[100] = 136;
            #endregion Locations
            #region Convert
            if (OldLeft == 88 && OldTop == 640)
                iOld = 1;
            if (OldLeft == 144 && OldTop == 640)
                iOld = 2;
            if (OldLeft == 200 && OldTop == 640)
                iOld = 3;
            if (OldLeft == 256 && OldTop == 640)
                iOld = 4;
            if (OldLeft == 312 && OldTop == 640)
                iOld = 5;
            if (OldLeft == 368 && OldTop == 640)
                iOld = 6;
            if (OldLeft == 424 && OldTop == 640)
                iOld = 7;
            if (OldLeft == 480 && OldTop == 640)
                iOld = 8;
            if (OldLeft == 536 && OldTop == 640)
                iOld = 9;
            if (OldLeft == 592 && OldTop == 640)
                iOld = 10;
            if (OldLeft == 592&& OldTop ==  584)
                iOld = 11;
            if (OldLeft == 536 && OldTop == 584)
                iOld = 12;
            if (OldLeft == 480 && OldTop == 584)
                iOld = 13;
            if (OldLeft == 424 && OldTop == 584)
                iOld = 14;
            if (OldLeft == 368 && OldTop == 584)
                iOld = 15;
            if (OldLeft == 312 && OldTop == 584)
                iOld = 16;
            if (OldLeft == 256 && OldTop == 584)
                iOld = 17;
            if (OldLeft == 200 && OldTop == 584)
                iOld = 18;
            if (OldLeft == 144 && OldTop == 584)
                iOld = 19;
            if (OldLeft == 88 && OldTop == 584)
                iOld = 20;
            if (OldLeft == 88 && OldTop == 528)
                iOld = 21;
            if (OldLeft == 144 && OldTop == 528)
                iOld = 22;
            if (OldLeft == 200 && OldTop == 528)
                iOld = 23;
            if (OldLeft == 256 && OldTop == 528)
                iOld = 24;
            if (OldLeft == 312 && OldTop == 528)
                iOld = 25;
            if (OldLeft == 368 && OldTop == 528)
                iOld = 6;
            if (OldLeft == 424 && OldTop == 528)
                iOld = 27;
            if (OldLeft == 480 && OldTop == 528)
                iOld = 28;
            if (OldLeft == 536 && OldTop == 528)
                iOld = 29;
            if (OldLeft == 592 && OldTop == 528)
                iOld = 30;
            if (OldLeft == 592 && OldTop ==  472)
                iOld = 31;
            if (OldLeft == 536 && OldTop == 472)
                iOld = 32;
            if (OldLeft == 480 && OldTop == 472)
                iOld = 33;
            if (OldLeft == 424 && OldTop == 472)
                iOld = 34;
            if (OldLeft == 368 && OldTop == 472)
                iOld = 35;
            if (OldLeft == 312 && OldTop == 472)
                iOld = 36;
            if (OldLeft == 256 && OldTop == 472)
                iOld = 37;
            if (OldLeft == 200 && OldTop == 472)
                iOld = 38;
            if (OldLeft == 144 && OldTop == 472)
                iOld = 39;
            if (OldLeft == 88 && OldTop == 472)
                iOld = 40;
            if (OldLeft == 88 && OldTop == 416)
                iOld = 41;
            if (OldLeft == 144 && OldTop == 416)
                iOld = 42;
            if (OldLeft == 200 && OldTop == 416)
                iOld = 43;
            if (OldLeft == 256 && OldTop == 416)
                iOld = 44;
            if (OldLeft == 312 && OldTop == 416)
                iOld = 45;
            if (OldLeft == 368 && OldTop == 416)
                iOld = 46;
            if (OldLeft == 424 && OldTop == 416)
                iOld = 47;
            if (OldLeft == 480 && OldTop == 416)
                iOld = 48;
            if (OldLeft == 536 && OldTop == 416)
                iOld = 49;
            if (OldLeft == 592 && OldTop == 416)
                iOld = 50;
            if (OldLeft == 592 && OldTop == 360)
                iOld = 51;
            if (OldLeft == 536 && OldTop == 360)
                iOld = 52;
            if (OldLeft == 480 && OldTop == 360)
                iOld = 53;
            if (OldLeft == 424 && OldTop == 360)
                iOld = 54;
            if (OldLeft == 368 && OldTop == 360)
                iOld = 55;
            if (OldLeft == 312 && OldTop == 360)
                iOld = 56;
            if (OldLeft == 256 && OldTop == 360)
                iOld = 57;
            if (OldLeft == 200 && OldTop == 360)
                iOld = 58;
            if (OldLeft == 144 && OldTop == 360)
                iOld = 59;
            if (OldLeft == 88 && OldTop == 360)
                iOld = 60;
            if (OldLeft == 88 && OldTop == 304)
                iOld = 61;
            if (OldLeft == 144 && OldTop == 304)
                iOld = 62;
            if (OldLeft == 200 && OldTop == 304)
                iOld = 63;
            if (OldLeft == 256 && OldTop == 304)
                iOld = 64;
            if (OldLeft == 312 && OldTop == 304)
                iOld = 65;
            if (OldLeft == 368 && OldTop == 304)
                iOld = 66;
            if (OldLeft == 424 && OldTop == 304)
                iOld = 67;
            if (OldLeft == 480 && OldTop == 304)
                iOld = 68;
            if (OldLeft == 536 && OldTop == 304)
                iOld = 69;
            if (OldLeft == 592 && OldTop == 304)
                iOld = 70;
            if (OldLeft == 592 && OldTop ==  248)
                iOld = 71;
            if (OldLeft == 536 && OldTop == 248)
                iOld = 72;
            if (OldLeft == 480 && OldTop == 248)
                iOld = 73;
            if (OldLeft == 424 && OldTop == 248)
                iOld = 74;
            if (OldLeft == 368 && OldTop == 248)
                iOld = 75;
            if (OldLeft == 312 && OldTop == 248)
                iOld = 76;
            if (OldLeft == 256 && OldTop == 248)
                iOld = 77;
            if (OldLeft == 200 && OldTop == 248)
                iOld = 78;
            if (OldLeft == 144 && OldTop == 248)
                iOld = 79;
            if (OldLeft == 88 && OldTop == 248)
                iOld = 80;
            if (OldLeft == 88 && OldTop == 192)
                iOld = 81;
            if (OldLeft == 144 && OldTop == 192)
                iOld = 82;
            if (OldLeft == 200 && OldTop == 192)
                iOld = 83;
            if (OldLeft == 256 && OldTop == 192)
                iOld = 84;
            if (OldLeft == 312 && OldTop == 192)
                iOld = 85;
            if (OldLeft == 368 && OldTop == 192)
                iOld = 86;
            if (OldLeft == 424 && OldTop == 192)
                iOld = 87;
            if (OldLeft == 480 && OldTop == 192)
                iOld = 88;
            if (OldLeft == 536 && OldTop == 192)
                iOld = 89;
            if (OldLeft == 592 && OldTop == 192)
                iOld = 90;
            if (OldLeft == 592 && OldTop ==  136)
                iOld = 91;
            if (OldLeft == 536 && OldTop == 136)
                iOld = 92;
            if (OldLeft == 480 && OldTop == 136)
                iOld = 93;
            if (OldLeft == 424 && OldTop == 136)
                iOld = 94;
            if (OldLeft == 368 && OldTop == 136)
                iOld = 95;
            if (OldLeft == 312&& OldTop ==  80)
                iOld = 96;
            if (OldLeft == 256 && OldTop == 136)
                iOld = 97;
            if (OldLeft == 200 && OldTop == 136)
                iOld = 98;
            if (OldLeft == 144 && OldTop == 136)
                iOld = 99;
            if (OldLeft == 88 && OldTop == 136)
                iOld = 100;
            #endregion Convert
            #region picMarbleOne
            if (LeftName=="picMarbleOne.Left" && TopName=="picMarbleOne.Top")
            {
                if (iOld + Number == 100)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Win.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(4000, 1000);
                    tmrGame.Stop();
                    picMarbleOne.Left = left[100];
                    picMarbleOne.Top = top[100];
                    MessageBox.Show(lblOne.Text + " به خانه رسید", "خانه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    grpStatus.Visible = true;
                    lblOnePerson00.Visible = true;
                    picOnePerson.Visible = true;
                    picOnePerson.Image = picColorOne.Image;
                    lblOnePerson.Text = lblOne.Text;
                    lblOnePerson.Visible = true;
                    btnNewGame.Visible = true;
                    btnRestart.Visible = true;
                    grpPlay.Enabled = false;
                    if (lblTwo.Visible == true)
                    {
                        lblTwoPerson00.Visible = true;
                        picTwoPerson.Visible = true;
                        picTwoPerson.Image = picColorTwo.Image;
                        lblTwoPerson.Text = lblTwo.Text;
                        lblTwoPerson.Visible = true;
                    }
                    if (lblThree.Visible == true)
                    {
                        lblThreePerson00.Visible = true;
                        picThreePerson.Visible = true;
                        picThreePerson.Image = picColorThree.Image;
                        lblThreePerson.Text = lblThree.Text;
                        lblThreePerson.Visible = true;
                    }
                    if (lblFour.Visible == true)
                    {
                        lblFourPerson00.Visible = true;
                        picFourPerson.Visible = true;
                        picFourPerson.Image = picColorFour.Image;
                        lblFourPerson.Text = lblFour.Text;
                        lblFourPerson.Visible = true;
                    }
                }
                if (iOld + Number > 100)
                    error = true;
                if (iOld + Number >= 1 && iOld + Number < 100)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Moving.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    picMarbleOne.Left = left[iOld + Number];
                    picMarbleOne.Top = top[iOld + Number];
                }
            }
            #endregion picMarbleOne
            #region picMarbleTwo
            if (LeftName == "picMarbleTwo.Left" && TopName == "picMarbleTwo.Top")
            {
                if (iOld + Number == 100)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Win.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(4000, 1000);
                    tmrGame.Stop();
                    picMarbleTwo.Left = left[100];
                    picMarbleTwo.Top = top[100];
                    MessageBox.Show(lblTwo.Text + " به خانه رسید", "خانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpStatus.Visible = true;
                    lblOnePerson00.Visible = true;
                    picOnePerson.Visible = true;
                    picOnePerson.Image = picColorTwo.Image;
                    lblOnePerson.Text = lblTwo.Text;
                    lblOnePerson.Visible = true;
                    lblTwoPerson00.Visible = true;
                    picTwoPerson.Visible = true;
                    picTwoPerson.Image = picColorOne.Image;
                    lblTwoPerson.Text = lblOne.Text;
                    lblTwoPerson.Visible = true;
                    btnNewGame.Visible = true;
                    btnRestart.Visible = true;
                    grpPlay.Enabled = false;
                    if (lblThree.Visible == true)
                    {
                        lblThreePerson00.Visible = true;
                        picThreePerson.Visible = true;
                        picThreePerson.Image = picColorThree.Image;
                        lblThreePerson.Text = lblThree.Text;
                        lblThreePerson.Visible = true;
                    }
                    if (lblFour.Visible == true)
                    {
                        lblFourPerson00.Visible = true;
                        picFourPerson.Visible = true;
                        picFourPerson.Image = picColorFour.Image;
                        lblFourPerson.Text = lblFour.Text;
                        lblFourPerson.Visible = true;
                    }
                }
                if (iOld + Number > 100)
                    error = true;
                if (iOld + Number >= 1 && iOld + Number < 100)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Moving.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    picMarbleTwo.Left = left[iOld + Number];
                    picMarbleTwo.Top = top[iOld + Number];
                }
            }
            #endregion picMarbleTwo
            #region picMarbleThree
            if (LeftName == "picMarbleThree.Left" && TopName == "picMarbleThree.Top")
            {
                if (iOld + Number == 100)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Win.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(4000, 1000);
                    tmrGame.Stop();
                    picMarbleThree.Left = left[100];
                    picMarbleThree.Top = top[100];
                    MessageBox.Show(lblThree.Text + " به خانه رسید", "خانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpStatus.Visible = true;
                    lblOnePerson00.Visible = true;
                    picOnePerson.Visible = true;
                    picOnePerson.Image = picColorThree.Image;
                    lblOnePerson.Text = lblThree.Text;
                    lblOnePerson.Visible = true;
                    lblTwoPerson00.Visible = true;
                    picTwoPerson.Visible = true;
                    picTwoPerson.Image = picColorOne.Image;
                    lblTwoPerson.Text = lblOne.Text;
                    lblTwoPerson.Visible = true;
                    lblThreePerson00.Visible = true;
                    picThreePerson.Visible = true;
                    picThreePerson.Image = picColorTwo.Image;
                    lblThreePerson.Text = lblTwo.Text;
                    lblThreePerson.Visible = true;
                    btnNewGame.Visible = true;
                    btnRestart.Visible = true;
                    grpPlay.Enabled = false;
                    if (lblFour.Visible == true)
                    {
                        lblFourPerson00.Visible = true;
                        picFourPerson.Visible = true;
                        picFourPerson.Image = picColorFour.Image;
                        lblFourPerson.Text = lblFour.Text;
                        lblFourPerson.Visible = true;
                    }
                }
                if (iOld + Number > 100)
                    error = true;
                if (iOld + Number >= 1 && iOld + Number < 100)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Moving.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    picMarbleThree.Left = left[iOld + Number];
                    picMarbleThree.Top = top[iOld + Number];
                }
            }
            #endregion picMarbleThree
            #region picMarbleFour
            if (LeftName == "picMarbleFour.Left" && TopName == "picMarbleFour.Top")
            {
                if (iOld + Number == 100)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Win.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(4000, 1000);
                    tmrGame.Stop();
                    picMarbleFour.Left = left[100];
                    picMarbleFour.Top = top[100];
                    MessageBox.Show(lblFour.Text + " به خانه رسید", "خانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpStatus.Visible = true;
                    lblOnePerson00.Visible = true;
                    picOnePerson.Visible = true;
                    picOnePerson.Image = picColorFour.Image;
                    lblOnePerson.Text = lblFour.Text;
                    lblOnePerson.Visible = true;
                    lblTwoPerson00.Visible = true;
                    picTwoPerson.Visible = true;
                    picTwoPerson.Image = picColorOne.Image;
                    lblTwoPerson.Text = lblOne.Text;
                    lblTwoPerson.Visible = true;
                    lblThreePerson00.Visible = true;
                    picThreePerson.Visible = true;
                    picThreePerson.Image = picColorTwo.Image;
                    lblThreePerson.Text = lblTwo.Text;
                    lblThreePerson.Visible = true;
                    lblFourPerson00.Visible = true;
                    picFourPerson.Visible = true;
                    picFourPerson.Image = picColorThree.Image;
                    lblFourPerson.Text = lblThree.Text;
                    lblFourPerson.Visible = true;
                    btnNewGame.Visible = true;
                    btnRestart.Visible = true;
                    grpPlay.Enabled = false;
                }
                if (iOld + Number > 100)
                    error = true;
                if (iOld + Number >= 1 && iOld + Number < 100)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Moving.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    picMarbleFour.Left = left[iOld + Number];
                    picMarbleFour.Top = top[iOld + Number];
                }
            }
            #endregion picMarbleFour
        }
        private void DisableRating()
        {
            ratingStar1.Visible = false;
            ratingStar2.Visible = false;
            ratingStar3.Visible = false;
            ratingStar4.Visible = false;
            ratingStar5.Visible = false;
            ratingStar6.Visible = false;
            ratingStar7.Visible = false;
            ratingStar8.Visible = false;
            ratingStar9.Visible = false;
            ratingStar10.Visible = false;
            ratingStar11.Visible = false;
            ratingStar12.Visible = false;
            ratingStar13.Visible = false;
            ratingStar14.Visible = false;
            ratingStar15.Visible = false;
            ratingStar16.Visible = false;
            ratingStar17.Visible = false;
            ratingStar18.Visible = false;
            ratingStar19.Visible = false;
            ratingStar20.Visible = false;
            ratingStar21.Visible = false;
            ratingStar22.Visible = false;
            ratingStar23.Visible = false;
            ratingStar24.Visible = false;
            ratingStar25.Visible = false;
            ratingStar26.Visible = false;
            ratingStar27.Visible = false;
            ratingStar28.Visible = false;
            ratingStar29.Visible = false;
            ratingStar30.Visible = false;
            ratingStar31.Visible = false;
            ratingStar32.Visible = false;
            ratingStar33.Visible = false;
            ratingStar34.Visible = false;
        }
        #endregion Functions...
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
            {
                player0.SoundLocation = path0;
                player0.Play();
            }
            cpu[1] = 0;
            cpu[2] = 0;
            cpu[3] = 0;
            cpu[4] = 0;
            start[1] = 0;
            start[2] = 0;
            start[3] = 0;
            start[4] = 0;
            tmrRating.Start();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            #region Errors...
            #region NotSelected
            if (chkOne.Checked == false && chkTwo.Checked == false && chkThree.Checked == false && chkFour.Checked == false)
            {
                if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    SystemSounds.Hand.Play();
                if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                    Console.Beep(2000, 200);
                blnError.Enabled = true;
                blnError.SetBalloonText(grpUser, "هیچ بازیکنی انتخاب نشده است");
                blnError.ShowBalloon(grpUser);
                blnError.Enabled = false;
                goto err;
            }
            #endregion NotSelected
            #region TextName
            if (chkOne.Checked == true)
                if (txtOne.Text == "")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(txtOne, "نام این بازیکن خالی است");
                    blnError.ShowBalloon(txtOne);
                    blnError.Enabled = false;
                    txtOne.Focus();
                    goto err;
                }
            if (chkTwo.Checked == true)
                if (txtTwo.Text == "")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(txtTwo, "نام این بازیکن خالی است");
                    blnError.ShowBalloon(txtTwo);
                    blnError.Enabled = false;
                    txtTwo.Focus();
                    goto err;
                }
            if (chkThree.Checked == true)
                if (txtThree.Text == "")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(txtThree, "نام این بازیکن خالی است");
                    blnError.ShowBalloon(txtThree);
                    blnError.Enabled = false;
                    txtThree.Focus();
                    goto err;
                }
            if (chkFour.Checked == true)
                if (txtFour.Text == "")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(txtFour, "نام این بازیکن خالی است");
                    blnError.ShowBalloon(txtFour);
                    blnError.Enabled = false;
                    txtFour.Focus();
                    goto err;
                }
            if (txtFour.Text != "")
                if ((chkOne.Checked == true && txtFour.Text == txtOne.Text) ||
                    (chkTwo.Checked == true && txtFour.Text == txtTwo.Text) ||
                    (chkThree.Checked == true && txtFour.Text == txtThree.Text))
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(txtFour, "این نام انتخاب شده است");
                    blnError.ShowBalloon(txtFour);
                    blnError.Enabled = false;
                    txtFour.Focus();
                    txtFour.SelectAll();
                    goto err;
                }
            if (txtThree.Text != "")
                if ((chkOne.Checked == true && txtThree.Text == txtOne.Text) ||
                    (chkTwo.Checked == true && txtThree.Text == txtTwo.Text) ||
                    (chkFour.Checked == true && txtThree.Text == txtFour.Text))
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(txtThree, "این نام انتخاب شده است");
                    blnError.ShowBalloon(txtThree);
                    blnError.Enabled = false;
                    txtThree.Focus();
                    txtThree.SelectAll();
                    goto err;
                }
            if (txtTwo.Text != "")
                if ((chkOne.Checked == true && txtTwo.Text == txtOne.Text) ||
                    (chkThree.Checked == true && txtTwo.Text == txtThree.Text) ||
                    (chkFour.Checked == true && txtTwo.Text == txtFour.Text))
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(txtTwo, "این نام انتخاب شده است");
                    blnError.ShowBalloon(txtTwo);
                    blnError.Enabled = false;
                    txtTwo.Focus();
                    txtTwo.SelectAll();
                    goto err;
                }
            if (txtOne.Text != "")
                if ((chkTwo.Checked == true && txtOne.Text == txtTwo.Text) ||
                    (chkThree.Checked == true && txtOne.Text == txtThree.Text) ||
                    (chkFour.Checked == true && txtOne.Text == txtFour.Text))
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(txtOne, "این نام انتخاب شده است");
                    blnError.ShowBalloon(txtOne);
                    blnError.Enabled = false;
                    txtOne.Focus();
                    txtOne.SelectAll();
                    goto err;
                }
            #endregion TextName
            #region ComboColor
            if (chkOne.Checked == true)
                if (cmbColorOne.Text == "رنگ")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(cmbColorOne, "رنگ این بازیکن انتخاب نشده است");
                    blnError.ShowBalloon(cmbColorOne);
                    blnError.Enabled = false;
                    goto err;
                }
            if (chkTwo.Checked == true)
                if (cmbColorTwo.Text == "رنگ")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(cmbColorTwo, "رنگ این بازیکن انتخاب نشده است");
                    blnError.ShowBalloon(cmbColorTwo);
                    blnError.Enabled = false;
                    goto err;
                }
            if (chkThree.Checked == true)
                if (cmbColorThree.Text == "رنگ")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(cmbColorThree, "رنگ این بازیکن انتخاب نشده است");
                    blnError.ShowBalloon(cmbColorThree);
                    blnError.Enabled = false;
                    goto err;
                }
            if (chkFour.Checked == true)
                if (cmbColorFour.Text == "رنگ")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(cmbColorFour, "رنگ این بازیکن انتخاب نشده است");
                    blnError.ShowBalloon(cmbColorFour);
                    blnError.Enabled = false;
                    goto err;
                }
            if ((chkOne.Checked == true && cmbColorFour.SelectedIndex == cmbColorOne.SelectedIndex) ||
                (chkTwo.Checked == true && cmbColorFour.SelectedIndex == cmbColorTwo.SelectedIndex) ||
                (chkThree.Checked == true && cmbColorFour.SelectedIndex == cmbColorThree.SelectedIndex))
            {
                if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    SystemSounds.Hand.Play();
                if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                    Console.Beep(2000, 200);
                blnError.Enabled = true;
                blnError.SetBalloonText(cmbColorFour, "این رنگ انتخاب شده است");
                blnError.ShowBalloon(cmbColorFour);
                blnError.Enabled = false;
                cmbColorFour.Focus();
                cmbColorFour.SelectAll();
                goto err;
            }
            if ((chkOne.Checked == true && cmbColorThree.SelectedIndex == cmbColorOne.SelectedIndex) ||
                (chkTwo.Checked == true && cmbColorThree.SelectedIndex == cmbColorTwo.SelectedIndex) ||
                (chkFour.Checked == true && cmbColorThree.SelectedIndex == cmbColorFour.SelectedIndex))
            {
                if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    SystemSounds.Hand.Play();
                if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                    Console.Beep(2000, 200);
                blnError.Enabled = true;
                blnError.SetBalloonText(cmbColorThree, "این رنگ انتخاب شده است");
                blnError.ShowBalloon(cmbColorThree);
                blnError.Enabled = false;
                cmbColorThree.Focus();
                cmbColorThree.SelectAll();
                goto err;
            }
            if ((chkOne.Checked == true && cmbColorTwo.SelectedIndex == cmbColorOne.SelectedIndex) ||
                (chkThree.Checked == true && cmbColorTwo.SelectedIndex == cmbColorThree.SelectedIndex) ||
                (chkFour.Checked == true && cmbColorTwo.SelectedIndex == cmbColorFour.SelectedIndex))
            {
                if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    SystemSounds.Hand.Play();
                if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                    Console.Beep(2000, 200);
                blnError.Enabled = true;
                blnError.SetBalloonText(cmbColorTwo, "این رنگ انتخاب شده است");
                blnError.ShowBalloon(cmbColorTwo);
                blnError.Enabled = false;
                cmbColorTwo.Focus();
                cmbColorTwo.SelectAll();
                goto err;
            }
            if ((chkTwo.Checked == true && cmbColorOne.SelectedIndex == cmbColorTwo.SelectedIndex) ||
                (chkThree.Checked == true && cmbColorOne.SelectedIndex == cmbColorThree.SelectedIndex) ||
                (chkFour.Checked == true && cmbColorOne.SelectedIndex == cmbColorFour.SelectedIndex))
            {
                if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    SystemSounds.Hand.Play();
                if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                    Console.Beep(2000, 200);
                blnError.Enabled = true;
                blnError.SetBalloonText(cmbColorOne, "این رنگ انتخاب شده است");
                blnError.ShowBalloon(cmbColorOne);
                blnError.Enabled = false;
                cmbColorOne.Focus();
                cmbColorOne.SelectAll();
                goto err;
            }
            #endregion ComboColor
            #region ComboUser
            if (chkOne.Checked == true)
                if (cmbUserOne.Text == "بازیکن")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(cmbUserOne, "نوع این بازیکن انتخاب نشده است");
                    blnError.ShowBalloon(cmbUserOne);
                    blnError.Enabled = false;
                    goto err;
                }
            if (chkTwo.Checked == true)
                if (cmbUserTwo.Text == "بازیکن")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(cmbUserTwo, "نوع این بازیکن انتخاب نشده است");
                    blnError.ShowBalloon(cmbUserTwo);
                    blnError.Enabled = false;
                    goto err;
                }
            if (chkThree.Checked == true)
                if (cmbUserThree.Text == "بازیکن")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(cmbUserThree, "نوع این بازیکن انتخاب نشده است");
                    blnError.ShowBalloon(cmbUserThree);
                    blnError.Enabled = false;
                    goto err;
                }
            if (chkFour.Checked == true)
                if (cmbUserFour.Text == "بازیکن")
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                        SystemSounds.Hand.Play();
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(2000, 200);
                    blnError.Enabled = true;
                    blnError.SetBalloonText(cmbUserFour, "نوع این بازیکن انتخاب نشده است");
                    blnError.ShowBalloon(cmbUserFour);
                    blnError.Enabled = false;
                    goto err;
                }
            #endregion ComboUser
            #endregion Error...
            #region Play
                if (chkOne.Checked == true)
            {
                if (cmbUserOne.SelectedIndex == 1)
                    cpu[1] = 1;
                lblOne.Text = txtOne.Text;
                lblOne.Visible = true;
                picColorOne.Visible = true;
                if (cmbColorOne.SelectedIndex == 0)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorOne.SelectedIndex == 1)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorOne.SelectedIndex == 2)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorOne.SelectedIndex == 3)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkTwo.Checked == true && chkOne.Checked == false)
            {
                if (cmbUserTwo.SelectedIndex == 1)
                    cpu[1] = 1;
                lblOne.Text = txtTwo.Text;
                lblOne.Visible = true;
                picColorOne.Visible = true;
                if (cmbColorTwo.SelectedIndex == 0)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorTwo.SelectedIndex == 1)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorTwo.SelectedIndex == 2)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorTwo.SelectedIndex == 3)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkTwo.Checked == true && chkOne.Checked == true)
            {
                if (cmbUserOne.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserTwo.SelectedIndex == 1)
                    cpu[2] = 1;
                lblTwo.Text = txtTwo.Text;
                lblTwo.Visible = true;
                picColorTwo.Visible = true;
                if (cmbColorTwo.SelectedIndex == 0)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorTwo.SelectedIndex == 1)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorTwo.SelectedIndex == 2)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorTwo.SelectedIndex == 3)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkThree.Checked == true && chkOne.Checked == false && chkTwo.Checked == false)
            {
                if (cmbUserThree.SelectedIndex == 1)
                    cpu[1] = 1;
                lblOne.Text = txtThree.Text;
                lblOne.Visible = true;
                picColorOne.Visible = true;
                if (cmbColorThree.SelectedIndex == 0)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorThree.SelectedIndex == 1)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorThree.SelectedIndex == 2)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorThree.SelectedIndex == 3)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkThree.Checked == true && chkOne.Checked == true && chkTwo.Checked == false)
            {
                if (cmbUserOne.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserThree.SelectedIndex == 1)
                    cpu[2] = 1;
                lblTwo.Text = txtThree.Text;
                lblTwo.Visible = true;
                picColorTwo.Visible = true;
                if (cmbColorThree.SelectedIndex == 0)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorThree.SelectedIndex == 1)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorThree.SelectedIndex == 2)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorThree.SelectedIndex == 3)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkThree.Checked == true && chkOne.Checked == false && chkTwo.Checked == true)
            {
                if (cmbUserTwo.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserThree.SelectedIndex == 1)
                    cpu[2] = 1;
                lblTwo.Text = txtThree.Text;
                lblTwo.Visible = true;
                picColorTwo.Visible = true;
                if (cmbColorThree.SelectedIndex == 0)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorThree.SelectedIndex == 1)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorThree.SelectedIndex == 2)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorThree.SelectedIndex == 3)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkThree.Checked == true && chkOne.Checked == true && chkTwo.Checked == true)
            {
                if (cmbUserOne.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserTwo.SelectedIndex == 1)
                    cpu[2] = 1;
                if (cmbUserThree.SelectedIndex == 1)
                    cpu[3] = 1;
                lblThree.Text = txtThree.Text;
                lblThree.Visible = true;
                picColorThree.Visible = true;
                if (cmbColorThree.SelectedIndex == 0)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorThree.SelectedIndex == 1)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorThree.SelectedIndex == 2)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorThree.SelectedIndex == 3)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkFour.Checked == true && chkOne.Checked == false && chkTwo.Checked == false && chkThree.Checked == false)
            {
                if (cmbUserFour.SelectedIndex == 1)
                    cpu[1] = 1;
                lblOne.Text = txtFour.Text;
                lblOne.Visible = true;
                picColorOne.Visible = true;
                if (cmbColorFour.SelectedIndex == 0)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorFour.SelectedIndex == 1)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorFour.SelectedIndex == 2)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorFour.SelectedIndex == 3)
                    picColorOne.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkFour.Checked == true && chkOne.Checked == true && chkTwo.Checked == false && chkThree.Checked == false)
            {
                if (cmbUserOne.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserFour.SelectedIndex == 1)
                    cpu[2] = 1;
                lblTwo.Text = txtFour.Text;
                lblTwo.Visible = true;
                picColorTwo.Visible = true;
                if (cmbColorFour.SelectedIndex == 0)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorFour.SelectedIndex == 1)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorFour.SelectedIndex == 2)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorFour.SelectedIndex == 3)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkFour.Checked == true && chkOne.Checked == true && chkTwo.Checked == true && chkThree.Checked == false)
            {
                if (cmbUserOne.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserTwo.SelectedIndex == 1)
                    cpu[2] = 1;
                if (cmbUserFour.SelectedIndex == 1)
                    cpu[3] = 1;
                lblThree.Text = txtFour.Text;
                lblThree.Visible = true;
                picColorThree.Visible = true;
                if (cmbColorFour.SelectedIndex == 0)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorFour.SelectedIndex == 1)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorFour.SelectedIndex == 2)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorFour.SelectedIndex == 3)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkFour.Checked == true && chkOne.Checked == true && chkTwo.Checked == false && chkThree.Checked == true)
            {
                if (cmbUserOne.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserThree.SelectedIndex == 1)
                    cpu[2] = 1;
                if (cmbUserFour.SelectedIndex == 1)
                    cpu[3] = 1;
                lblThree.Text = txtFour.Text;
                lblThree.Visible = true;
                picColorThree.Visible = true;
                if (cmbColorFour.SelectedIndex == 0)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorFour.SelectedIndex == 1)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorFour.SelectedIndex == 2)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorFour.SelectedIndex == 3)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkFour.Checked == true && chkOne.Checked == false && chkTwo.Checked == true && chkThree.Checked == true)
            {
                if (cmbUserTwo.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserThree.SelectedIndex == 1)
                    cpu[2] = 1;
                if (cmbUserFour.SelectedIndex == 1)
                    cpu[3] = 1;
                lblThree.Text = txtFour.Text;
                lblThree.Visible = true;
                picColorThree.Visible = true;
                if (cmbColorFour.SelectedIndex == 0)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorFour.SelectedIndex == 1)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorFour.SelectedIndex == 2)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorFour.SelectedIndex == 3)
                    picColorThree.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkFour.Checked == true && chkOne.Checked == false && chkTwo.Checked == true && chkThree.Checked == false)
            {
                if (cmbUserTwo.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserFour.SelectedIndex == 1)
                    cpu[2] = 1;
                lblTwo.Text = txtFour.Text;
                lblTwo.Visible = true;
                picColorTwo.Visible = true;
                if (cmbColorFour.SelectedIndex == 0)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorFour.SelectedIndex == 1)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorFour.SelectedIndex == 2)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorFour.SelectedIndex == 3)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkFour.Checked == true && chkOne.Checked == false && chkTwo.Checked == false && chkThree.Checked == true)
            {
                if (cmbUserThree.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserFour.SelectedIndex == 1)
                    cpu[2] = 1;
                lblTwo.Text = txtFour.Text;
                lblTwo.Visible = true;
                picColorTwo.Visible = true;
                if (cmbColorFour.SelectedIndex == 0)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorFour.SelectedIndex == 1)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorFour.SelectedIndex == 2)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorFour.SelectedIndex == 3)
                    picColorTwo.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            if (chkFour.Checked == true && chkOne.Checked == true && chkTwo.Checked == true && chkThree.Checked == true)
            {
                if (cmbUserOne.SelectedIndex == 1)
                    cpu[1] = 1;
                if (cmbUserTwo.SelectedIndex == 1)
                    cpu[2] = 1;
                if (cmbUserThree.SelectedIndex == 1)
                    cpu[3] = 1;
                if (cmbUserFour.SelectedIndex == 1)
                    cpu[4] = 1;
                lblFour.Text = txtFour.Text;
                lblFour.Visible = true;
                picColorFour.Visible = true;
                if (cmbColorFour.SelectedIndex == 0)
                    picColorFour.Image = Snake_And_Ladder.Properties.Resources.Red;
                if (cmbColorFour.SelectedIndex == 1)
                    picColorFour.Image = Snake_And_Ladder.Properties.Resources.Blue;
                if (cmbColorFour.SelectedIndex == 2)
                    picColorFour.Image = Snake_And_Ladder.Properties.Resources.Green;
                if (cmbColorFour.SelectedIndex == 3)
                    picColorFour.Image = Snake_And_Ladder.Properties.Resources.Yellow;
            }
            #endregion Play
            #region Disable...
            grpUser.Enabled = false;
            #endregion Disable...
            #region Show
            grpPlay.Visible = true;
            mnuRestart.Enabled = true;
            if (lblOne.Visible == true)
            {
                btnOne.Visible = true;
                picOne.Visible = true;
                picMarbleOne.Visible = true;
                picMarbleOne.Image = picColorOne.Image;
            }
            if (lblTwo.Visible == true)
            {
                btnTwo.Visible = true;
                picTwo.Visible = true;
                picMarbleTwo.Visible = true;
                picMarbleTwo.Image = picColorTwo.Image;
            }
            if (lblThree.Visible == true)
            {
                btnThree.Visible = true;
                picThree.Visible = true;
                picMarbleThree.Visible = true;
                picMarbleThree.Image = picColorThree.Image;
            }
            if (lblFour.Visible == true)
            {
                btnFour.Visible = true;
                picFour.Visible = true;
                picMarbleFour.Visible = true;
                picMarbleFour.Image = picColorFour.Image;
            }
            picEnable.Visible = true;
            btnOne.Enabled = true;
            tmrGame.Start();
            #endregion Show
            #region errLabel
        err:
            error = true;
            #endregion errLabel
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            mnuRestart.Enabled = false;
            iOld = 1;
            cpu[1] = 0;
            cpu[2] = 0;
            cpu[3] = 0;
            cpu[4] = 0;
            start[1] = 0;
            start[2] = 0;
            start[3] = 0;
            start[4] = 0;
            tmrGame.Stop();
            picMarbleOne.Left = 16;
            picMarbleOne.Top = 640;
            picMarbleTwo.Left = 16;
            picMarbleTwo.Top = 584;
            picMarbleThree.Left = 16;
            picMarbleThree.Top = 528;
            picMarbleFour.Left = 16;
            picMarbleFour.Top = 572;
            picEnable.Left = 280;
            picEnable.Top = 16;
            picMarbleOne.Image = null;
            picMarbleTwo.Image = null;
            picMarbleThree.Image = null;
            picMarbleFour.Image = null;
            grpStatus.Visible = false;
            grpPlay.Visible = false;
            grpUser.Enabled = true;
            chkOne.Enabled = true;
            chkTwo.Enabled = true;
            chkThree.Enabled = true;
            chkFour.Enabled = true;
            btnStart.Enabled = true;
            chkOne.Checked = false;
            chkTwo.Checked = false;
            chkThree.Checked = false;
            chkFour.Checked = false;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (btnOne.Visible == true)
                btnOne.Enabled = true;
            if (btnTwo.Visible == true)
                btnTwo.Enabled = false;
            if (btnThree.Visible == true)
                btnThree.Enabled = false;
            if (btnFour.Visible == true)
                btnFour.Enabled = false;
            picMarbleOne.Left = 16;
            picMarbleOne.Top = 640;
            picMarbleTwo.Left = 16;
            picMarbleTwo.Top = 584;
            picMarbleThree.Left = 16;
            picMarbleThree.Top = 528;
            picMarbleFour.Left = 16;
            picMarbleFour.Top = 572;
            picEnable.Left = 280;
            picEnable.Top = 16;
            grpStatus.Visible = false;
            Application.Restart();
        }
        #region checkBoxs...
        private void chkFour_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFour.Checked == true)
            {
                txtFour.Enabled = true;
                cmbColorFour.Enabled = true;
                cmbUserFour.Enabled = true;
                txtFour.Text = null;
                txtFour.Focus();
            }
            if (chkFour.Checked == false)
            {
                txtFour.Enabled = false;
                cmbColorFour.Enabled = false;
                cmbUserFour.Enabled = false;
                txtFour.Text = "نام...";
                cmbColorFour.Text = "رنگ";
                cmbUserFour.Text = "بازیکن";
            }
        }
        private void chkThree_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThree.Checked == true)
            {
                txtThree.Enabled = true;
                cmbColorThree.Enabled = true;
                cmbUserThree.Enabled = true;
                txtThree.Text = null;
                txtThree.Focus();
            }
            if (chkThree.Checked == false)
            {
                txtThree.Enabled = false;
                cmbColorThree.Enabled = false;
                cmbUserThree.Enabled = false;
                txtThree.Text = "نام...";
                cmbColorThree.Text = "رنگ";
                cmbUserThree.Text = "بازیکن";
            }
        }
        private void chkTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTwo.Checked == true)
            {
                txtTwo.Enabled = true;
                cmbColorTwo.Enabled = true;
                cmbUserTwo.Enabled = true;
                txtTwo.Text = null;
                txtTwo.Focus();
            }
            if (chkTwo.Checked == false)
            {
                txtTwo.Enabled = false;
                cmbColorTwo.Enabled = false;
                cmbUserTwo.Enabled = false;
                txtTwo.Text = "نام...";
                cmbColorTwo.Text = "رنگ";
                cmbUserTwo.Text = "بازیکن";
            }
        }
        private void chkOne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOne.Checked == true)
            {
                txtOne.Enabled = true;
                cmbColorOne.Enabled = true;
                cmbUserOne.Enabled = true;
                txtOne.Text = null;
                txtOne.Focus();
            }
            if (chkOne.Checked == false)
            {
                txtOne.Enabled = false;
                cmbColorOne.Enabled = false;
                cmbUserOne.Enabled = false;
                txtOne.Text = "نام...";
                cmbColorOne.Text = "رنگ";
                cmbUserOne.Text = "بازیکن";
            }
        }
        #endregion checkBoxs...
        #region Buttons...
        private void btnOne_Click(object sender, EventArgs e)
        {
            lblInfoOne.Visible = false;
            Int32 num1 = number.Next(6) + 1;

            if (start[1] == 0)
            {
                if (num1 == 6)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Reward.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(3200, 100);
                    picOne.Image = Snake_And_Ladder.Properties.Resources._1;
                    picMarbleOne.Left = 88;
                    picMarbleOne.Top = 640;
                    lblInfoOne.Text = "ورود";
                    lblInfoOne.Visible = true;
                    start[1] = 1;

                    if (btnTwo.Visible == true && lblInfoOne.Visible == false)
                    {
                        picColorOne.Enabled = false;
                        lblOne.Enabled = false;
                        btnOne.Enabled = false;
                        picOne.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 56;
                        picColorTwo.Enabled = true;
                        lblTwo.Enabled = true;
                        btnTwo.Enabled = true;
                        picTwo.Enabled = true;
                        picTwo.Image = null;
                    }
                }

                else
                {
                    if (num1 == 1)
                        picOne.Image = Snake_And_Ladder.Properties.Resources._1;
                    if (num1 == 2)
                        picOne.Image = Snake_And_Ladder.Properties.Resources._2;
                    if (num1 == 3)
                        picOne.Image = Snake_And_Ladder.Properties.Resources._3;
                    if (num1 == 4)
                        picOne.Image = Snake_And_Ladder.Properties.Resources._4;
                    if (num1 == 5)
                        picOne.Image = Snake_And_Ladder.Properties.Resources._5;
                   
                    if (btnTwo.Visible == true && lblInfoOne.Visible == false)
                    {
                        picColorOne.Enabled = false;
                        lblOne.Enabled = false;
                        btnOne.Enabled = false;
                        picOne.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 56;
                        picColorTwo.Enabled = true;
                        lblTwo.Enabled = true;
                        btnTwo.Enabled = true;
                        picTwo.Enabled = true;
                        picTwo.Image = null;
                    }
                }
            }

            else
            {
                if (num1 == 1)
                {
                    picOne.Image = Snake_And_Ladder.Properties.Resources._1;
                    Status(picMarbleOne.Left, picMarbleOne.Top, 1, "picMarbleOne.Left", "picMarbleOne.Top");
                }
                if (num1 == 2)
                {
                    picOne.Image = Snake_And_Ladder.Properties.Resources._2;
                    Status(picMarbleOne.Left, picMarbleOne.Top, 2, "picMarbleOne.Left", "picMarbleOne.Top");
                }
                if (num1 == 3)
                {
                    picOne.Image = Snake_And_Ladder.Properties.Resources._3;
                    Status(picMarbleOne.Left, picMarbleOne.Top, 3, "picMarbleOne.Left", "picMarbleOne.Top");
                }
                if (num1 == 4)
                {
                    picOne.Image = Snake_And_Ladder.Properties.Resources._4;
                    Status(picMarbleOne.Left, picMarbleOne.Top, 4, "picMarbleOne.Left", "picMarbleOne.Top");
                }
                if (num1 == 5)
                {
                    picOne.Image = Snake_And_Ladder.Properties.Resources._5;
                    Status(picMarbleOne.Left, picMarbleOne.Top, 5, "picMarbleOne.Left", "picMarbleOne.Top");
                }
                if (num1 == 6)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Reward.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(80, 80);
                    picOne.Image = Snake_And_Ladder.Properties.Resources._6;
                    lblInfoOne.Text = "جایزه!";
                    lblInfoOne.Visible = true;
                    Status(picMarbleOne.Left, picMarbleOne.Top, 6, "picMarbleOne.Left", "picMarbleOne.Top");
                }

                #region Ladders...
                if (picMarbleOne.Left == 480 && picMarbleOne.Top == 640)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleOne.Left = 424;
                    picMarbleOne.Top = 528;
                }
                if (picMarbleOne.Left == 312 && picMarbleOne.Top == 584)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleOne.Left = 200;
                    picMarbleOne.Top = 472;
                }
                if (picMarbleOne.Left == 88 && picMarbleOne.Top == 528)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleOne.Left = 200;
                    picMarbleOne.Top = 304;
                }
                if (picMarbleOne.Left == 592 && picMarbleOne.Top == 472)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleOne.Left = 480;
                    picMarbleOne.Top = 416;
                }
                if (picMarbleOne.Left == 424 && picMarbleOne.Top == 416)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleOne.Left = 312;
                    picMarbleOne.Top = 192;
                }
                if (picMarbleOne.Left == 592 && picMarbleOne.Top == 248)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleOne.Left = 536;
                    picMarbleOne.Top = 136;
                }
                if (picMarbleOne.Left == 200 && picMarbleOne.Top == 192)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleOne.Left = 144;
                    picMarbleOne.Top = 136;
                }
                #endregion Ladders...
                #region Snakes...
                if (picMarbleOne.Left == 536 && picMarbleOne.Top == 528)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleOne.Left = 368;
                    picMarbleOne.Top = 640;
                    lblInfoOne.Visible = false;
                }
                if (picMarbleOne.Left == 312 && picMarbleOne.Top == 472)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleOne.Left = 256;
                    picMarbleOne.Top = 584;
                    lblInfoOne.Visible = false;
                }
                if (picMarbleOne.Left == 88 && picMarbleOne.Top == 416)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleOne.Left = 144;
                    picMarbleOne.Top = 584;
                    lblInfoOne.Visible = false;
                }
                if (picMarbleOne.Left == 592 && picMarbleOne.Top == 304)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleOne.Left = 424;
                    picMarbleOne.Top = 360;
                    lblInfoOne.Visible = false;
                }
                if (picMarbleOne.Left == 312 && picMarbleOne.Top == 248)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleOne.Left = 200;
                    picMarbleOne.Top = 528;
                    lblInfoOne.Visible = false;
                }
                if (picMarbleOne.Left == 480 && picMarbleOne.Top == 136)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleOne.Left = 424;
                    picMarbleOne.Top = 248;
                    lblInfoOne.Visible = false;
                }
                if (picMarbleOne.Left == 256 && picMarbleOne.Top == 136)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleOne.Left = 368;
                    picMarbleOne.Top = 248;
                    lblInfoOne.Visible = false;
                }
                #endregion Snakes...

                if (btnTwo.Visible == true && lblInfoOne.Visible == false)
                {
                    picColorOne.Enabled = false;
                    lblOne.Enabled = false;
                    btnOne.Enabled = false;
                    picOne.Enabled = false;
                    picEnable.Left = 280;
                    picEnable.Top = 56;
                    picColorTwo.Enabled = true;
                    lblTwo.Enabled = true;
                    btnTwo.Enabled = true;
                    picTwo.Enabled = true;
                    picTwo.Image = null;
                }
            }
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblInfoTwo.Visible = false;
            Int32 num2 = number.Next(6) + 1;

            if (start[2] == 0)
            {
                if (num2 == 6)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Reward.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(3200, 100);
                    picTwo.Image = Snake_And_Ladder.Properties.Resources._1;
                    picMarbleTwo.Left = 88;
                    picMarbleTwo.Top = 640;
                    lblInfoTwo.Text = "ورود";
                    lblInfoTwo.Visible = true;
                    start[2] = 1;

                    if (btnThree.Visible == true && lblInfoTwo.Visible == false)
                    {
                        picColorTwo.Enabled = false;
                        lblTwo.Enabled = false;
                        btnTwo.Enabled = false;
                        picTwo.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 96;
                        picColorThree.Enabled = true;
                        lblThree.Enabled = true;
                        btnThree.Enabled = true;
                        picThree.Enabled = true;
                        picThree.Image = null;
                    }

                    if (btnThree.Visible == false && lblInfoTwo.Visible == false)
                    {
                        picColorTwo.Enabled = false;
                        lblTwo.Enabled = false;
                        btnTwo.Enabled = false;
                        picTwo.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 16;
                        picColorOne.Enabled = true;
                        lblOne.Enabled = true;
                        btnOne.Enabled = true;
                        picOne.Enabled = true;
                        picOne.Image = null;
                    }
                }

                else
                {
                    if (num2 == 1)
                        picTwo.Image = Snake_And_Ladder.Properties.Resources._1;
                    if (num2 == 2)
                        picTwo.Image = Snake_And_Ladder.Properties.Resources._2;
                    if (num2 == 3)
                        picTwo.Image = Snake_And_Ladder.Properties.Resources._3;
                    if (num2 == 4)
                        picTwo.Image = Snake_And_Ladder.Properties.Resources._4;
                    if (num2 == 5)
                        picTwo.Image = Snake_And_Ladder.Properties.Resources._5;
                   
                    if (btnThree.Visible == true && lblInfoTwo.Visible == false)
                    {
                        picColorTwo.Enabled = false;
                        lblTwo.Enabled = false;
                        btnTwo.Enabled = false;
                        picTwo.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 96;
                        picColorThree.Enabled = true;
                        lblThree.Enabled = true;
                        btnThree.Enabled = true;
                        picThree.Enabled = true;
                        picThree.Image = null;
                    }

                    if (btnThree.Visible == false && lblInfoTwo.Visible == false)
                    {
                        picColorTwo.Enabled = false;
                        lblTwo.Enabled = false;
                        btnTwo.Enabled = false;
                        picTwo.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 16;
                        picColorOne.Enabled = true;
                        lblOne.Enabled = true;
                        btnOne.Enabled = true;
                        picOne.Enabled = true;
                        picOne.Image = null;
                    }
                }
            }

            else
            {
                if (num2 == 1)
                {
                    picTwo.Image = Snake_And_Ladder.Properties.Resources._1;
                    Status(picMarbleTwo.Left, picMarbleTwo.Top, 1, "picMarbleTwo.Left", "picMarbleTwo.Top");
                }
                if (num2 == 2)
                {
                    picTwo.Image = Snake_And_Ladder.Properties.Resources._2;
                    Status(picMarbleTwo.Left, picMarbleTwo.Top, 2, "picMarbleTwo.Left", "picMarbleTwo.Top");
                }
                if (num2 == 3)
                {
                    picTwo.Image = Snake_And_Ladder.Properties.Resources._3;
                    Status(picMarbleTwo.Left, picMarbleTwo.Top, 3, "picMarbleTwo.Left", "picMarbleTwo.Top");
                }
                if (num2 == 4)
                {
                    picTwo.Image = Snake_And_Ladder.Properties.Resources._4;
                    Status(picMarbleTwo.Left, picMarbleTwo.Top, 4, "picMarbleTwo.Left", "picMarbleTwo.Top");
                }
                if (num2 == 5)
                {
                    picTwo.Image = Snake_And_Ladder.Properties.Resources._5;
                    Status(picMarbleTwo.Left, picMarbleTwo.Top, 5, "picMarbleTwo.Left", "picMarbleTwo.Top");
                }
                if (num2 == 6)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Reward.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(80, 80);
                    picTwo.Image = Snake_And_Ladder.Properties.Resources._6;
                    lblInfoTwo.Text = "جایزه!";
                    lblInfoTwo.Visible = true;
                    Status(picMarbleTwo.Left, picMarbleTwo.Top, 6, "picMarbleTwo.Left", "picMarbleTwo.Top");
                }

                #region Ladders...
                if (picMarbleTwo.Left == 480 && picMarbleTwo.Top == 640)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleTwo.Left = 424;
                    picMarbleTwo.Top = 528;
                }
                if (picMarbleTwo.Left == 312 && picMarbleTwo.Top == 584)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleTwo.Left = 200;
                    picMarbleTwo.Top = 472;
                }
                if (picMarbleTwo.Left == 88 && picMarbleTwo.Top == 528)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleTwo.Left = 200;
                    picMarbleTwo.Top = 304;
                }
                if (picMarbleTwo.Left == 592 && picMarbleTwo.Top == 472)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleTwo.Left = 480;
                    picMarbleTwo.Top = 416;
                }
                if (picMarbleTwo.Left == 424 && picMarbleTwo.Top == 416)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleTwo.Left = 312;
                    picMarbleTwo.Top = 192;
                }
                if (picMarbleTwo.Left == 592 && picMarbleTwo.Top == 248)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleTwo.Left = 536;
                    picMarbleTwo.Top = 136;
                }
                if (picMarbleTwo.Left == 200 && picMarbleTwo.Top == 192)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleTwo.Left = 144;
                    picMarbleTwo.Top = 136;
                }
                #endregion Ladders...
                #region Snakes...
                if (picMarbleTwo.Left == 536 && picMarbleTwo.Top == 528)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleTwo.Left = 368;
                    picMarbleTwo.Top = 640;
                    lblInfoTwo.Visible = false;
                }
                if (picMarbleTwo.Left == 312 && picMarbleTwo.Top == 472)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleTwo.Left = 256;
                    picMarbleTwo.Top = 584;
                    lblInfoTwo.Visible = false;
                }
                if (picMarbleTwo.Left == 88 && picMarbleTwo.Top == 416)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleTwo.Left = 144;
                    picMarbleTwo.Top = 584;
                    lblInfoTwo.Visible = false;
                }
                if (picMarbleTwo.Left == 592 && picMarbleTwo.Top == 304)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleTwo.Left = 424;
                    picMarbleTwo.Top = 360;
                    lblInfoTwo.Visible = false;
                }
                if (picMarbleTwo.Left == 312 && picMarbleTwo.Top == 248)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleTwo.Left = 200;
                    picMarbleTwo.Top = 528;
                    lblInfoTwo.Visible = false;
                }
                if (picMarbleTwo.Left == 480 && picMarbleTwo.Top == 136)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleTwo.Left = 424;
                    picMarbleTwo.Top = 248;
                    lblInfoTwo.Visible = false;
                }
                if (picMarbleTwo.Left == 256 && picMarbleTwo.Top == 136)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleTwo.Left = 368;
                    picMarbleTwo.Top = 248;
                    lblInfoTwo.Visible = false;
                }
                #endregion Snakes...

                if (btnThree.Visible == true && lblInfoTwo.Visible == false)
                {
                    picColorTwo.Enabled = false;
                    lblTwo.Enabled = false;
                    btnTwo.Enabled = false;
                    picTwo.Enabled = false;
                    picEnable.Left = 280;
                    picEnable.Top = 96;
                    picColorThree.Enabled = true;
                    lblThree.Enabled = true;
                    btnThree.Enabled = true;
                    picThree.Enabled = true;
                    picThree.Image = null;
                }

                if (btnThree.Visible == false && lblInfoTwo.Visible == false)
                {
                    picColorTwo.Enabled = false;
                    lblTwo.Enabled = false;
                    btnTwo.Enabled = false;
                    picTwo.Enabled = false;
                    picEnable.Left = 280;
                    picEnable.Top = 16;
                    picColorOne.Enabled = true;
                    lblOne.Enabled = true;
                    btnOne.Enabled = true;
                    picOne.Enabled = true;
                    picOne.Image = null;
                }
            }
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            lblInfoThree.Visible = false;
            Int32 num3 = number.Next(6) + 1;

            if (start[3] == 0)
            {
                if (num3 == 6)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Reward.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(3200, 100);
                    picThree.Image = Snake_And_Ladder.Properties.Resources._1;
                    picMarbleThree.Left = 88;
                    picMarbleThree.Top = 640;
                    lblInfoThree.Text = "ورود";
                    lblInfoThree.Visible = true;
                    start[3] = 1;

                    if (btnFour.Visible == true && lblInfoThree.Visible == false)
                    {
                        picColorThree.Enabled = false;
                        lblThree.Enabled = false;
                        btnThree.Enabled = false;
                        picThree.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 136;
                        picColorFour.Enabled = true;
                        lblFour.Enabled = true;
                        btnFour.Enabled = true;
                        picFour.Enabled = true;

                        picFour.Image = null;
                    }
                    if (btnFour.Visible == false && lblInfoThree.Visible == false)
                    {
                        picColorThree.Enabled = false;
                        lblThree.Enabled = false;
                        btnThree.Enabled = false;
                        picThree.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 16;
                        picColorOne.Enabled = true;
                        lblOne.Enabled = true;
                        btnOne.Enabled = true;
                        picOne.Enabled = true;
                        picOne.Image = null;

                    }
                }

                else
                {
                    if (num3 == 1)
                        picThree.Image = Snake_And_Ladder.Properties.Resources._1;
                    if (num3 == 2)
                        picThree.Image = Snake_And_Ladder.Properties.Resources._2;
                    if (num3 == 3)
                        picThree.Image = Snake_And_Ladder.Properties.Resources._3;
                    if (num3 == 4)
                        picThree.Image = Snake_And_Ladder.Properties.Resources._4;
                    if (num3 == 5)
                        picThree.Image = Snake_And_Ladder.Properties.Resources._5;
                    
                    if (btnFour.Visible == true && lblInfoThree.Visible == false)
                    {
                        picColorThree.Enabled = false;
                        lblThree.Enabled = false;
                        btnThree.Enabled = false;
                        picThree.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 136;
                        picColorFour.Enabled = true;
                        lblFour.Enabled = true;
                        btnFour.Enabled = true;
                        picFour.Enabled = true;

                        picFour.Image = null;
                    }
                    if (btnFour.Visible == false && lblInfoThree.Visible == false)
                    {
                        picColorThree.Enabled = false;
                        lblThree.Enabled = false;
                        btnThree.Enabled = false;
                        picThree.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 16;
                        picColorOne.Enabled = true;
                        lblOne.Enabled = true;
                        btnOne.Enabled = true;
                        picOne.Enabled = true;
                        picOne.Image = null;
                    }
                }
            }

            else
            {
                if (num3 == 1)
                {
                    picThree.Image = Snake_And_Ladder.Properties.Resources._1;
                    Status(picMarbleThree.Left, picMarbleThree.Top, 5, "picMarbleThree.Left", "picMarbleThree.Top");
                }
                if (num3 == 2)
                {
                    picThree.Image = Snake_And_Ladder.Properties.Resources._2;
                    Status(picMarbleThree.Left, picMarbleThree.Top, 5, "picMarbleThree.Left", "picMarbleThree.Top");
                }
                if (num3 == 3)
                {
                    picThree.Image = Snake_And_Ladder.Properties.Resources._3;
                    Status(picMarbleThree.Left, picMarbleThree.Top, 5, "picMarbleThree.Left", "picMarbleThree.Top");
                }
                if (num3 == 4)
                {
                    picThree.Image = Snake_And_Ladder.Properties.Resources._4;
                    Status(picMarbleThree.Left, picMarbleThree.Top, 5, "picMarbleThree.Left", "picMarbleThree.Top");
                }
                if (num3 == 5)
                {
                    picThree.Image = Snake_And_Ladder.Properties.Resources._5;
                    Status(picMarbleThree.Left, picMarbleThree.Top, 5, "picMarbleThree.Left", "picMarbleThree.Top");
                }
                if (num3 == 6)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Reward.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(80, 80);
                    picThree.Image = Snake_And_Ladder.Properties.Resources._6;
                    lblInfoThree.Text = "جایزه!";
                    lblInfoThree.Visible = true;
                    Status(picMarbleThree.Left, picMarbleThree.Top, 5, "picMarbleThree.Left", "picMarbleThree.Top");
                }

                #region Ladders...
                if (picMarbleThree.Left == 480 && picMarbleThree.Top == 640)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleThree.Left = 424;
                    picMarbleThree.Top = 528;
                }
                if (picMarbleThree.Left == 312 && picMarbleThree.Top == 584)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleThree.Left = 200;
                    picMarbleThree.Top = 472;
                }
                if (picMarbleThree.Left == 88 && picMarbleThree.Top == 528)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleThree.Left = 200;
                    picMarbleThree.Top = 304;
                }
                if (picMarbleThree.Left == 592 && picMarbleThree.Top == 472)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleThree.Left = 480;
                    picMarbleThree.Top = 416;
                }
                if (picMarbleThree.Left == 424 && picMarbleThree.Top == 416)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleThree.Left = 312;
                    picMarbleThree.Top = 192;
                }
                if (picMarbleThree.Left == 592 && picMarbleThree.Top == 248)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleThree.Left = 536;
                    picMarbleThree.Top = 136;
                }
                if (picMarbleThree.Left == 200 && picMarbleThree.Top == 192)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleThree.Left = 144;
                    picMarbleThree.Top = 136;
                }
                #endregion Ladders...
                #region Snakes...
                if (picMarbleThree.Left == 536 && picMarbleThree.Top == 528)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleThree.Left = 368;
                    picMarbleThree.Top = 640;
                    lblInfoThree.Visible = false;
                }
                if (picMarbleThree.Left == 312 && picMarbleThree.Top == 472)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleThree.Left = 256;
                    picMarbleThree.Top = 584;
                    lblInfoThree.Visible = false;
                }
                if (picMarbleThree.Left == 88 && picMarbleThree.Top == 416)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleThree.Left = 144;
                    picMarbleThree.Top = 584;
                    lblInfoThree.Visible = false;
                }
                if (picMarbleThree.Left == 592 && picMarbleThree.Top == 304)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleThree.Left = 424;
                    picMarbleThree.Top = 360;
                    lblInfoThree.Visible = false;
                }
                if (picMarbleThree.Left == 312 && picMarbleThree.Top == 248)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleThree.Left = 200;
                    picMarbleThree.Top = 528;
                    lblInfoThree.Visible = false;
                }
                if (picMarbleThree.Left == 480 && picMarbleThree.Top == 136)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleThree.Left = 424;
                    picMarbleThree.Top = 248;
                    lblInfoThree.Visible = false;
                }
                if (picMarbleThree.Left == 256 && picMarbleThree.Top == 136)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleThree.Left = 368;
                    picMarbleThree.Top = 248;
                    lblInfoThree.Visible = false;
                }
                #endregion Snakes...

                if (btnFour.Visible == true && lblInfoThree.Visible == false)
                {
                    picColorThree.Enabled = false;
                    lblThree.Enabled = false;
                    btnThree.Enabled = false;
                    picThree.Enabled = false;
                    picEnable.Left = 280;
                    picEnable.Top = 136;
                    picColorFour.Enabled = true;
                    lblFour.Enabled = true;
                    btnFour.Enabled = true;
                    picFour.Enabled = true;
                    picFour.Image = null;
                }
                if (btnFour.Visible == false && lblInfoThree.Visible == false)
                {
                    picColorThree.Enabled = false;
                    lblThree.Enabled = false;
                    btnThree.Enabled = false;
                    picThree.Enabled = false;
                    picEnable.Left = 280;
                    picEnable.Top = 16;
                    picColorOne.Enabled = true;
                    lblOne.Enabled = true;
                    btnOne.Enabled = true;
                    picOne.Enabled = true;
                    picOne.Image = null;
                }
            }
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            lblInfoFour.Visible = false;
            Int32 num4 = number.Next(6) + 1;

            if (start[4] == 0)
            {
                if (num4 == 6)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Reward.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(3200, 100);
                    picFour.Image = Snake_And_Ladder.Properties.Resources._1;
                    picMarbleFour.Left = 88;
                    picMarbleFour.Top = 640;
                    lblInfoFour.Text = "ورود";
                    lblInfoFour.Visible = true;
                    start[4] = 1;

                    if (btnOne.Visible == true && lblInfoFour.Visible == false)
                    {
                        picColorFour.Enabled = false;
                        lblFour.Enabled = false;
                        btnFour.Enabled = false;
                        picFour.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 16;
                        picColorOne.Enabled = true;
                        lblOne.Enabled = true;
                        btnOne.Enabled = true;
                        picOne.Enabled = true;
                        picOne.Image = null;
                    }
                }

                else
                {
                    if (num4 == 1)
                        picFour.Image = Snake_And_Ladder.Properties.Resources._1;
                    if (num4 == 2)
                        picFour.Image = Snake_And_Ladder.Properties.Resources._2;
                    if (num4 == 3)
                        picFour.Image = Snake_And_Ladder.Properties.Resources._3;
                    if (num4 == 4)
                        picFour.Image = Snake_And_Ladder.Properties.Resources._4;
                    if (num4 == 5)
                        picFour.Image = Snake_And_Ladder.Properties.Resources._5;
                    
                    if (btnOne.Visible == true && lblInfoFour.Visible == false)
                    {
                        picColorFour.Enabled = false;
                        lblFour.Enabled = false;
                        btnFour.Enabled = false;
                        picFour.Enabled = false;
                        picEnable.Left = 280;
                        picEnable.Top = 16;
                        picColorOne.Enabled = true;
                        lblOne.Enabled = true;
                        btnOne.Enabled = true;
                        picOne.Enabled = true;
                        picOne.Image = null;
                    }
                }
            }

            else
            {
                if (num4 == 1)
                {
                    picFour.Image = Snake_And_Ladder.Properties.Resources._1;
                    Status(picMarbleFour.Left, picMarbleFour.Top, 5, "picMarbleFour.Left", "picMarbleFour.Top");
                }
                if (num4 == 2)
                {
                    picFour.Image = Snake_And_Ladder.Properties.Resources._2;
                    Status(picMarbleFour.Left, picMarbleFour.Top, 5, "picMarbleFour.Left", "picMarbleFour.Top");
                }
                if (num4 == 3)
                {
                    picFour.Image = Snake_And_Ladder.Properties.Resources._3;
                    Status(picMarbleFour.Left, picMarbleFour.Top, 5, "picMarbleFour.Left", "picMarbleFour.Top");
                }
                if (num4 == 4)
                {
                    picFour.Image = Snake_And_Ladder.Properties.Resources._4;
                    Status(picMarbleFour.Left, picMarbleFour.Top, 5, "picMarbleFour.Left", "picMarbleFour.Top");
                }
                if (num4 == 5)
                {
                    picFour.Image = Snake_And_Ladder.Properties.Resources._5;
                    Status(picMarbleFour.Left, picMarbleFour.Top, 5, "picMarbleFour.Left", "picMarbleFour.Top");
                }
                if (num4 == 6)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Reward.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(80, 80);
                    picFour.Image = Snake_And_Ladder.Properties.Resources._6;
                    lblInfoFour.Text = "جایزه!";
                    lblInfoFour.Visible = true;
                    Status(picMarbleFour.Left, picMarbleFour.Top, 5, "picMarbleFour.Left", "picMarbleFour.Top");
                }

                #region Ladders...
                if (picMarbleFour.Left == 480 && picMarbleFour.Top == 640)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleFour.Left = 424;
                    picMarbleFour.Top = 528;
                }
                if (picMarbleFour.Left == 312 && picMarbleFour.Top == 584)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleFour.Left = 200;
                    picMarbleFour.Top = 472;
                }
                if (picMarbleFour.Left == 88 && picMarbleFour.Top == 528)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleFour.Left = 200;
                    picMarbleFour.Top = 304;
                }
                if (picMarbleFour.Left == 592 && picMarbleFour.Top == 472)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleFour.Left = 480;
                    picMarbleFour.Top = 416;
                }
                if (picMarbleFour.Left == 424 && picMarbleFour.Top == 416)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleFour.Left = 312;
                    picMarbleFour.Top = 192;
                }
                if (picMarbleFour.Left == 592 && picMarbleFour.Top == 248)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleFour.Left = 536;
                    picMarbleFour.Top = 136;
                }
                if (picMarbleFour.Left == 200 && picMarbleFour.Top == 192)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Ladder.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(1000, 100);
                    picMarbleFour.Left = 144;
                    picMarbleFour.Top = 136;
                }
                #endregion Ladders...
                #region Snakes...
                if (picMarbleFour.Left == 536 && picMarbleFour.Top == 528)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleFour.Left = 368;
                    picMarbleFour.Top = 640;
                    lblInfoFour.Visible = false;
                }
                if (picMarbleFour.Left == 312 && picMarbleFour.Top == 472)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleFour.Left = 256;
                    picMarbleFour.Top = 584;
                    lblInfoFour.Visible = false;
                }
                if (picMarbleFour.Left == 88 && picMarbleFour.Top == 416)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleFour.Left = 144;
                    picMarbleFour.Top = 584;
                    lblInfoFour.Visible = false;
                }
                if (picMarbleFour.Left == 592 && picMarbleFour.Top == 304)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleFour.Left = 424;
                    picMarbleFour.Top = 360;
                    lblInfoFour.Visible = false;
                }
                if (picMarbleFour.Left == 312 && picMarbleFour.Top == 248)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleFour.Left = 200;
                    picMarbleFour.Top = 528;
                    lblInfoFour.Visible = false;
                }
                if (picMarbleFour.Left == 480 && picMarbleFour.Top == 136)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleFour.Left = 424;
                    picMarbleFour.Top = 248;
                    lblInfoFour.Visible = false;
                }
                if (picMarbleFour.Left == 256 && picMarbleFour.Top == 136)
                {
                    if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                    {
                        SoundPlayer player = new SoundPlayer();
                        string path = ".\\Sound\\Snake.wav";
                        player.SoundLocation = path;
                        player.Play();
                    }
                    if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                        Console.Beep(9000, 100);
                    picMarbleFour.Left = 368;
                    picMarbleFour.Top = 248;
                    lblInfoFour.Visible = false;
                }
                #endregion Snakes...

                if (btnOne.Visible == true && lblInfoFour.Visible == false)
                {
                    picColorFour.Enabled = false;
                    lblFour.Enabled = false;
                    btnFour.Enabled = false;
                    picFour.Enabled = false;
                    picEnable.Left = 280;
                    picEnable.Top = 16;
                    picColorOne.Enabled = true;
                    lblOne.Enabled = true;
                    btnOne.Enabled = true;
                    picOne.Enabled = true;
                    picOne.Image = null;
                }
            }
        }
        #endregion Buttons...
        #region Timer...
        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (btnOne.Enabled == true && cpu[1] == 1)
                btnOne_Click(sender, e);
            if (btnTwo.Enabled == true && cpu[2] == 1)
                btnTwo_Click(sender, e);
            if (btnThree.Enabled == true && cpu[3] == 1)
                btnThree_Click(sender, e);
            if (btnFour.Enabled == true && cpu[4] == 1)
                btnFour_Click(sender, e);
        }
        private void tmrRating_Tick(object sender, EventArgs e)
        {
            if (star == 35) star = 1;
            if (star == 1) { DisableRating(); ratingStar1.Visible = true; goto end; }
            if (star == 2) { DisableRating(); ratingStar2.Visible = true; goto end; }
            if (star == 3) { DisableRating(); ratingStar3.Visible = true; goto end; }
            if (star == 4) { DisableRating(); ratingStar4.Visible = true; goto end; }
            if (star == 5) { DisableRating(); ratingStar5.Visible = true; goto end; }
            if (star == 6) { DisableRating(); ratingStar6.Visible = true; goto end; }
            if (star == 7) { DisableRating(); ratingStar7.Visible = true; goto end; }
            if (star == 8) { DisableRating(); ratingStar8.Visible = true; goto end; }
            if (star == 9) { DisableRating(); ratingStar9.Visible = true; goto end; }
            if (star == 10) { DisableRating(); ratingStar10.Visible = true; goto end; }
            if (star == 11) { DisableRating(); ratingStar11.Visible = true; goto end; }
            if (star == 12) { DisableRating(); ratingStar12.Visible = true; goto end; }
            if (star == 13) { DisableRating(); ratingStar13.Visible = true; goto end; }
            if (star == 14) { DisableRating(); ratingStar14.Visible = true; goto end; }
            if (star == 15) { DisableRating(); ratingStar15.Visible = true; goto end; }
            if (star == 16) { DisableRating(); ratingStar16.Visible = true; goto end; }
            if (star == 17) { DisableRating(); ratingStar17.Visible = true; goto end; }
            if (star == 18) { DisableRating(); ratingStar18.Visible = true; goto end; }
            if (star == 19) { DisableRating(); ratingStar19.Visible = true; goto end; }
            if (star == 20) { DisableRating(); ratingStar20.Visible = true; goto end; }
            if (star == 21) { DisableRating(); ratingStar21.Visible = true; goto end; }
            if (star == 22) { DisableRating(); ratingStar22.Visible = true; goto end; }
            if (star == 23) { DisableRating(); ratingStar23.Visible = true; goto end; }
            if (star == 24) { DisableRating(); ratingStar24.Visible = true; goto end; }
            if (star == 25) { DisableRating(); ratingStar25.Visible = true; goto end; }
            if (star == 26) { DisableRating(); ratingStar26.Visible = true; goto end; }
            if (star == 27) { DisableRating(); ratingStar27.Visible = true; goto end; }
            if (star == 28) { DisableRating(); ratingStar28.Visible = true; goto end; }
            if (star == 29) { DisableRating(); ratingStar29.Visible = true; goto end; }
            if (star == 30) { DisableRating(); ratingStar30.Visible = true; goto end; }
            if (star == 31) { DisableRating(); ratingStar31.Visible = true; goto end; }
            if (star == 32) { DisableRating(); ratingStar32.Visible = true; goto end; }
            if (star == 33) { DisableRating(); ratingStar33.Visible = true; goto end; }
            if (star == 34) { DisableRating(); ratingStar34.Visible = true; goto end; }
        end:
            star += 1;
        }
        #endregion Timer...
        #region MenuItems...
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            btnNewGame_Click(sender, e);
        }
        private void mnuRestart_Click(object sender, EventArgs e)
        {
            btnRestart_Click(sender, e);
        }
        private void rdoEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
            {
                player0.SoundLocation = path0;
                player0.Play();
            }
            if (rdoEnable.Checked == true)
                grpOutput.Enabled = true;
        }
        private void rdoDisable_CheckedChanged(object sender, EventArgs e)
        {
            player0.Stop();
            if (rdoDisable.Checked == true)
                grpOutput.Enabled = false;
        }
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
                SystemSounds.Asterisk.Play();
            if (rdoSystem.Checked == true && rdoEnable.Checked == true)
                Console.Beep(5000, 500);
            MessageBox.Show("طراحی و برنامه نویسی توسط" + Convert.ToChar(13) + "ایمان رضایی پور" + Convert.ToChar(13) + "امیر خوشبین" + Convert.ToChar(13) + "شهریار شماعی" + Convert.ToChar(13) + Convert.ToChar(13) + "****تمام حقوق محفوظ است****" + Convert.ToChar(13),
                "درباره مار و پله", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

        }
        private void rdoSpeaker_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSpeaker.Checked == true && rdoEnable.Checked == true)
            {
                player0.SoundLocation = path0;
                player0.Play();
            }
        }
        private void rdoSystem_CheckedChanged(object sender, EventArgs e)
        {
            player0.Stop();
        }
        #endregion MenuItems...
    }
}

/*
                                                                                                            
 .....                ..                   ..              ..      ..               ..     ..              
..   ..               ..                  ....             ..      ..               ..     ..              
..      .....   ..... .. ..   ....        ....  .....   .....      ..     .....  .....  .....  ....  ....  
 ...    ... .. ..  .. ....   ... ..       ..... ... .. ..  ..      ..    ..  .. ..  .. ..  .. ... .. ..    
   .... ..  ..     .. ...    ..  ..      ..  .. ..  .. ..  ..      ..        .. ..  .. ..  .. ..  .. ..    
..   .. ..  .. ...... ....   ......      ...... ..  .. ..  ..      ..    ...... ..  .. ..  .. ...... ..    
...  .. ..  .. ..  .. .. ..  ..  ..      ..   ....  .. ..  ..      ..    ..  .. ..  .. ..  .. ..  .. ..    
 .....  ..  .. ...... .. ..   ....      ..    ....  ..  .....      ............  .....  .....  ....  ..  

*/
