﻿/*
 *Generated by FuchsGUICodeGenerator
 *Ghoshehsoft@live.com
 *www.ghoshehsoft.wordpress.com
 *Time of generation: 2/9/2011 1:21:55 AM
*/

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using FuchsGUI;

namespace GUI
{
    public sealed class BrakeDataForm : Form
    {
        ContentManager contentManager;

        #region Fields

        public Button Hide;
        public Label label8;
        public Label label15;
        public Label label4;
        public Label label14;
        public Label label7;
        public Label label13;
        public Label label2;
        public Label label6;
        public Label label11;
        public Label label3;
        public Label label10;
        public Label label5;
        public Label label9;
        public Label label1;
        public TextBox Pistons_Number_T;
        public TextBox Max_Torque_T;
        public TextBox Caliper_Force_T;
        public TextBox Tire_Gorund_Force_T;
        public TextBox MC_Area_T;
        public TextBox Rotor_Brake_torque_T;
        public TextBox Caliper_Area_T;
        public TextBox input_Torque_T;
        public TextBox MCdiameter_T;
        public TextBox PF_Force_T;
        public TextBox MC_presssuer_T;
        public TextBox PF_Coef_T;
        public TextBox Pedal_ratio_T;
        public TextBox Driver_Force_T;

        #endregion

        public BrakeDataForm(Texture2D texture, SpriteFont font, Color foreColor, ContentManager contentManager)
            : base("Brake_GroupBox", "Brake_Form", new Rectangle(12, 12, 300, 750), texture, font, foreColor, null)
        {
            this.contentManager = contentManager;
            this.AddControls();
        }

        void AddControls()
        {
            Texture2D texButton = contentManager.Load<Texture2D>(@"GUI\texButton");
            Texture2D texTextBox = contentManager.Load<Texture2D>(@"GUI\texTextBox");


            Hide = new Button("Hide", @"Hide", new Rectangle(255, 355, 45, 26), texButton, font, new Color(0, 0, 0), null);
            this.AddControl(Hide);

            label8 = new Label("label8", @"Pistons Number", new Vector2(6, 237), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label8);

            label15 = new Label("label15", @"Force between Tire and Ground", new Vector2(6, 407), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label15);

            label4 = new Label("label4", @"Master Cylinder Area", new Vector2(6, 120), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label4);

            label14 = new Label("label14", @"input Torque", new Vector2(6, 384), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label14);

            label7 = new Label("label7", @"Calipr Area", new Vector2(6, 179), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label7);

            label13 = new Label("label13", @"Pad Friction coefficient", new Vector2(6, 268), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label13);

            label2 = new Label("label2", @"Driver_Force", new Vector2(6, 33), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label2);

            label6 = new Label("label6", @"Caliper Force ", new Vector2(6, 211), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label6);

            label11 = new Label("label11", @"Rotor Brake Torque", new Vector2(6, 329), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label11);

            label3 = new Label("label3", @"Pedal ratio", new Vector2(6, 62), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label3);

            label10 = new Label("label10", @"Maximum Torque", new Vector2(6, 355), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label10);

            label5 = new Label("label5", @"Master Cylinder Pressuer", new Vector2(6, 153), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label5);

            label9 = new Label("label9", @"Pad Friction Force", new Vector2(6, 297), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label9);

            label1 = new Label("label1", @"Master Cylinder Diameter", new Vector2(6, 94), font, new Color(0, 0, 0), 0, 0, null);
            this.AddControl(label1);

            Pistons_Number_T = new TextBox("Pistons_Number_T", @"", 32767, "", new Rectangle(149, 234, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            Pistons_Number_T.ReadOnly = true;
            this.AddControl(Pistons_Number_T);

            Max_Torque_T = new TextBox("Max_Torque_T", @"", 32767, "", new Rectangle(149, 352, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            Max_Torque_T.ReadOnly = true;
            this.AddControl(Max_Torque_T);

            Caliper_Force_T = new TextBox("Caliper_Force_T", @"", 32767, "", new Rectangle(149, 208, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            Caliper_Force_T.ReadOnly = true;
            this.AddControl(Caliper_Force_T);

            Tire_Gorund_Force_T = new TextBox("Tire_Gorund_Force_T", @"", 32767, "", new Rectangle(149, 407, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            Tire_Gorund_Force_T.ReadOnly = true;
            this.AddControl(Tire_Gorund_Force_T);

            MC_Area_T = new TextBox("MC_Area_T", @"", 32767, "", new Rectangle(149, 117, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            MC_Area_T.ReadOnly = true;
            this.AddControl(MC_Area_T);

            Rotor_Brake_torque_T = new TextBox("Rotor_Brake_torque_T", @"", 32767, "", new Rectangle(149, 326, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            Rotor_Brake_torque_T.ReadOnly = true;
            this.AddControl(Rotor_Brake_torque_T);

            Caliper_Area_T = new TextBox("Caliper_Area_T", @"", 32767, "", new Rectangle(149, 176, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            Caliper_Area_T.ReadOnly = true;
            this.AddControl(Caliper_Area_T);

            input_Torque_T = new TextBox("input_Torque_T", @"", 32767, "", new Rectangle(149, 381, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            input_Torque_T.ReadOnly = true;
            this.AddControl(input_Torque_T);

            MCdiameter_T = new TextBox("MCdiameter_T", @"", 32767, "", new Rectangle(149, 91, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            MCdiameter_T.ReadOnly = true;
            this.AddControl(MCdiameter_T);

            PF_Force_T = new TextBox("PF_Force_T", @"", 32767, "", new Rectangle(149, 294, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            PF_Force_T.ReadOnly = true;
            this.AddControl(PF_Force_T);

            MC_presssuer_T = new TextBox("MC_presssuer_T", @"", 32767, "", new Rectangle(149, 150, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            MC_presssuer_T.ReadOnly = true;
            this.AddControl(MC_presssuer_T);

            PF_Coef_T = new TextBox("PF_Coef_T", @"", 32767, "", new Rectangle(149, 268, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            PF_Coef_T.ReadOnly = true;
            this.AddControl(PF_Coef_T);

            Pedal_ratio_T = new TextBox("Pedal_ratio_T", @"", 32767, "", new Rectangle(149, 59, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            Pedal_ratio_T.ReadOnly = true;
            this.AddControl(Pedal_ratio_T);

            Driver_Force_T = new TextBox("Driver_Force_T", @"", 32767, "", new Rectangle(149, 33, 100, 21), texTextBox, font, new Color(0, 0, 0), null);
            Driver_Force_T.ReadOnly = true;
            this.AddControl(Driver_Force_T);


        }
    }
}