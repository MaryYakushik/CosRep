﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba1.Dependenses;
using Laba1.ParametrsFunctions;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Diagnostics;
using ZedGraph;

namespace Laba1
{
    public partial class Form1 : Form
    {
        private const string NO_DEPENDENSES = "no dependenses", A0 = "A0", W0 = "w0", F0 = "φ0", T = "t";
        private List<ParametrsFunction> parametrsFunctions = new List<ParametrsFunction>();
        bool poliharmonic = false;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        #region Comboboxes settings

        private void setDataInComboBoxes(ComboBox comboBox, String name)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(NO_DEPENDENSES);
            if (!Dependenses.Dependenses.hasDependenses(A0, name) && !A0.Equals(name))
            {
                comboBox.Items.Add(A0);
            }
            if (!Dependenses.Dependenses.hasDependenses(W0, name) && !W0.Equals(name))
            {
                comboBox.Items.Add(W0);
            }
            if (!Dependenses.Dependenses.hasDependenses(F0, name) && !F0.Equals(name))
            {
                comboBox.Items.Add(F0);
            }
            comboBox.Items.Add(T);
        }

        private void setParamentrs(System.Windows.Forms.Label label, TextBox box, String parametr)
        {
            if (!parametr.Equals(NO_DEPENDENSES))
            {
                label.Text = "* " + parametr + " +";
                label.Visible = true;
                box.Visible = true;
            }
            else
            {
                label.Text = "";
                label.Visible = false;
                box.Text = "";
                box.Visible = false;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            setDataInComboBoxes(comboBox1, A0);
            if (comboBox1.Text.Equals(""))
            {
                comboBox1.Text = NO_DEPENDENSES;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedItem = comboBox1.Text;
            Dependenses.Dependenses.setDependenses(groupA0.Text, selectedItem);
            setParamentrs(a0ParametrLabel, a0ParametrBox, selectedItem);
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            setDataInComboBoxes(comboBox2, W0);
            if (comboBox2.Text.Equals(""))
            {
                comboBox2.Text = NO_DEPENDENSES;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedItem = comboBox2.Text;
            Dependenses.Dependenses.setDependenses(groupW0.Text, selectedItem);
            setParamentrs(w0ParametrLabel, w0ParametrBox, selectedItem);
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            setDataInComboBoxes(comboBox3, F0);
            if (comboBox3.Text.Equals(""))
            {
                comboBox3.Text = NO_DEPENDENSES;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedItem = comboBox3.Text;
            Dependenses.Dependenses.setDependenses(groupF0.Text, selectedItem);
            setParamentrs(f0ParametrLabel, f0ParametrBox, selectedItem);
        }

        #endregion

        #region Add && Delete functions in listBox

        private void enableButtons(bool value)
        {
            oneLineButton.Enabled = value;
            addLineButton.Enabled = value;
            allLinesButton.Enabled = value;
            polyharmonicButton.Enabled = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parametrsFunctions.Add(new ParametrsFunction());
            int size = parametrsFunctions.Count - 1;

            List<bool> results = new List<bool>();
            results.Add(parametrsFunctions[size].function[0].setA(a0MainBox.Text));
            if(a0ParametrBox.Visible)
            {
                results.Add(parametrsFunctions[size].function[0].setB(a0ParametrBox.Text));
            }
            parametrsFunctions[size].function[0].setX(comboBox1.Text);

            results.Add(parametrsFunctions[size].function[1].setA(w0MainBox.Text));
            if(w0ParametrBox.Visible)
            {
                results.Add(parametrsFunctions[size].function[1].setB(w0ParametrBox.Text));
            }
            parametrsFunctions[size].function[1].setX(comboBox2.Text);

            results.Add(parametrsFunctions[size].function[2].setA(f0MainBox.Text));
            if(f0ParametrBox.Visible)
            {
                results.Add(parametrsFunctions[size].function[2].setB(f0ParametrBox.Text));
            }
            parametrsFunctions[size].function[2].setX(comboBox3.Text);

            parametrsFunctions[size].mainDependenses = Dependenses.Dependenses.getMainDependenses();
            if (results.Contains(false) || (listBox1.Items.Contains(parametrsFunctions[size].ToString())))
            {
                parametrsFunctions.RemoveAt(size);
                MessageBox.Show("Неправильный ввод или такая функция уже существует");
            }
            else
            {
                listBox1.Items.Add(parametrsFunctions[size].ToString());
                enableButtons(true);
                if (listBox1.SelectedIndex < 0)
                {
                    listBox1.SelectedIndex = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(selectedIndex);
                parametrsFunctions[selectedIndex].draw = false;
                parametrsFunctions.RemoveAt(selectedIndex);
                redrawLines();
                if (listBox1.Items.Count == 0)
                {
                    enableButtons(false);
                }
            }
            else
            {
                MessageBox.Show("Nothing to delete. Functions box is empty or none of the lines is not selected.");
            }
        }

        #endregion

        #region Draw Lines

        private void setDrawFalse(){
            for (int i = 0; i < parametrsFunctions.Count(); i++)
            {
                parametrsFunctions[i].draw = false;
            }
        }

        private void oneLineButton_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            poliharmonic = false;
            setDrawFalse();
            String message = "Nothing to draw. Functions box is empty or none of the lines is not selected.";
            drawLine(message);
        }

        private void addLineButton_Click(object sender, EventArgs e)
        {
            String message = "Nothing to add. Functions box is empty or none of the lines is not selected.";
            drawLine(message);
        }

        private void allLinesButton_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            poliharmonic = false;
            string seriesName;
            for (int i = 0; i < parametrsFunctions.Count; i++)
            {
                seriesName = "L" + i;
                parametrsFunctions[i].draw = true;
                drawFunction(seriesName, i);
            }
        }

        private void polyharmonicButton_Click(object sender, EventArgs e)
        {
            drawPoliharmonic();
        }

        private void drawPoliharmonic()
        {
            setDrawFalse();
            poliharmonic = true;
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            int linesCount = listBox1.Items.Count;
            int minGeneratedValue = -30;
            int maxGeneratedValue = 30;
            String fileName = "poliharmonicData.bin";
            PointPairList pointsList = new PointPairList();
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                for (int i = minGeneratedValue; i <= maxGeneratedValue; i++)
                {
                    double yValue = 0;
                    for (int j = 0; j < linesCount; j++)
                    {
                        yValue += getFunctionValue(i, j);
                    }
                    pointsList.Add(i, yValue);
                    writer.Write("x= " + i + "; y = " + yValue + ";\n");
                }
            }
            LineItem myCurve = pane.AddCurve("Pol", pointsList, generaterandomColor(), SymbolType.None);
            myCurve.Line.IsSmooth = true;
            myCurve.Line.Width = 2.0f;
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
            Process.Start("C:\\Windows\\System32\\notepad.exe", fileName);
        }

        private void drawLine(String message)
        {
            if (!poliharmonic)
            {
                poliharmonic = false;
                int selectedIndex = listBox1.SelectedIndex;
                string seriesName = "L" + selectedIndex;
                if (selectedIndex >= 0)
                {
                    drawFunction(seriesName, selectedIndex);
                    parametrsFunctions[selectedIndex].draw = true;
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
            else
            {
                MessageBox.Show("Impossible to add line to a poliharmonic signal.");
            }

        }

        Random random = new Random();
        private Color generaterandomColor()
        {
            
            return Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }

        private void drawFunction(String seriesName, int functionNumber)
        {
            GraphPane pane = zedGraph.GraphPane;
            int minGeneratedValue = -30;
            int maxGeneratedValue = 30;
            PointPairList pointsList = new PointPairList();
            for (int t = minGeneratedValue; t <= maxGeneratedValue; t++)
            {
                pointsList.Add(t, getFunctionValue(t, functionNumber));
            }
            LineItem myCurve = pane.AddCurve(seriesName, pointsList, generaterandomColor(), SymbolType.None);
            myCurve.Line.IsSmooth = true;
            myCurve.Line.Width = 2.0f;
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        double a0, w0, f0, t;
        private double getFunctionValue(int tValue, int functionNumber)
        {
            t = tValue;
            int countOfVariables = Dependenses.Dependenses.getCountOfVariables();
            List<List<int>> bufferedDependenses = parametrsFunctions[functionNumber].mainDependenses;
            bufferedDependenses = bufferedDependenses.OrderBy(x => x.Count).ToList();

            for (int i = 0; i < countOfVariables; i++)
            {
                int dependOn = -1;
                if (bufferedDependenses[0].Count > 1)
                {
                    dependOn = bufferedDependenses[0][1];
                }

                switch (bufferedDependenses[i][0])
                {
                    case 0:
                        a0 = GetParametrValue(i, dependOn, functionNumber);
                        break;
                    case 1:
                        w0 = GetParametrValue(i, dependOn, functionNumber);
                        break;
                    case 2:
                        f0 = GetParametrValue(i, dependOn, functionNumber);
                        break;
                }
            }
            return a0 * Math.Sin(w0 * t / Math.PI + f0);
        }

        private double GetParametrValue(int dependent, int dependOn, int functionNumber)
        {
            double a = parametrsFunctions[functionNumber].function[dependent].getA();
            double b = parametrsFunctions[functionNumber].function[dependent].getB();
            double result = 0;

            switch (dependOn)
            {
                case 0:
                    result = a * a0 + b;
                    break;
                case 1:
                    result = a * w0 + b;
                    break;
                case 2:
                    result = a * f0 + b;
                    break;
                case 3:
                    result = a * t + b;
                    break;
                case -1:
                    result = a;
                    break;
            }
            return result;
        }

        private void redrawLines()
        {
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            if (!poliharmonic)
            {
                for (int i = 0; i < parametrsFunctions.Count(); i++)
                {
                    if (parametrsFunctions[i].draw)
                    {
                        string seriesName = "L" + i;
                        drawFunction(seriesName, i);
                    }
                }
            }
            else
            {
                drawPoliharmonic();
            }
        }

        #endregion

    }
}
