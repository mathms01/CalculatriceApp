using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculatrice2
{
    class Calcul
    {

        public Calcul()
        {
            
        }

        public double Start(List<string> elements)
        {
            List<string> eleM = elements;
            eleM = normalize(eleM);
            int step = 1;
            while (step <= 4)
            {
                switch (step)
                {
                    case 1:
                        this.Parentheses(eleM);
                        break;
                    case 2:
                        this.Exposants(eleM);
                        break;
                    case 3:
                        this.MultiDiv(eleM);
                        break;
                    case 4:
                        this.AddiSous(eleM);
                        break;
                    default:
                        Console.WriteLine("Default operande");
                        break;
                }
                step += 1;
            }
            return double.Parse(elements[0]);
        }

        public List<string> normalize(List<string> elements)
        {
            List<string> eleM = elements;
            // && (eleM[0]  !=  "(" || eleM[0] != "." || eleM[0] != "√")
            if (!Regex.IsMatch(eleM[0], @"^\d+$") && (eleM[0] != "(" && eleM[0] != "." && eleM[0] != "√"))
            {
                eleM.Insert(0,"0");
            }

            /*if (!Regex.IsMatch(eleM[eleM.Count-1], @"^\d+$"))
            {
                eleM.Insert(eleM.Count, "0");
            } */

            return eleM;
        }

        public void Parentheses(List<string> elements)
        {
            for (int ope = 0; ope < elements.Count; ope++)
            {
                double res = 0.0f;
                if (elements[ope] == "(")
                {
                    int y = 0;
                    for (int opePart = ope+1; opePart < elements.Count; opePart++)
                    {
                        if (elements[opePart] == ")")
                        {
                            List<string> ele = new List<string>();
                            for (int eleRange = ope+1; eleRange < opePart; eleRange++)
                            {
                                ele.Add(elements[eleRange]);
                            }
                           //List<string> ele = new List<string>(elements.GetRange(ope + 1, opePart - 1));
                           res = Start(ele);
                            for (int del = ope; del <= y+1; del++)
                            {
                                elements.RemoveAt(ope);
                            }
                           elements.Insert(ope, res.ToString());
                            ope = 0;
                            break;
                        }
                        y += 1;
                    }
                }
            }
        }

        public void Exposants(List<string> elements)
        {
            for (int ope = 0; ope < elements.Count; ope++)
            {
                double res = 0.0f;
                if (elements[ope] == "^")
                {
                    res = double.Parse(elements[ope - 1], CultureInfo.InvariantCulture);
                    double v = (double.Parse(elements[ope + 1], CultureInfo.InvariantCulture) - 1.0);
                    for (int resI = 0; resI < v; resI++)
                    {
                        res *= double.Parse(elements[ope - 1], CultureInfo.InvariantCulture);
                    }
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.Insert(ope - 1, res.ToString());
                    ope -= 2;
                }
            }
        }

        public void MultiDiv(List<string> elements)
        {
            for (int ope = 0; ope < elements.Count; ope++)
            {
                double res = 0.0f;
                if (elements[ope] == "*")
                {
                    res = double.Parse(elements[ope-1], CultureInfo.InvariantCulture) * double.Parse(elements[ope+1], CultureInfo.InvariantCulture);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.Insert(ope - 1, res.ToString());
                    ope -= 2;
                }
                else if (elements[ope] == "/")
                {
                    res = double.Parse(elements[ope-1], CultureInfo.InvariantCulture) / double.Parse(elements[ope+1], CultureInfo.InvariantCulture);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.Insert(ope - 1, res.ToString());
                    ope -= 2;
                }
            }
            
            for (int ope = 0; ope < elements.Count; ope++)
            {
                double res = 0.0f;
                if (elements[ope] == "*")
                {
                    res = double.Parse(elements[ope-1], CultureInfo.InvariantCulture) * double.Parse(elements[ope+1], CultureInfo.InvariantCulture);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.Insert(ope - 1, res.ToString());
                    ope -= 2;
                }
                else if (elements[ope] == "/")
                {
                    res = double.Parse(elements[ope-1], CultureInfo.InvariantCulture) / double.Parse(elements[ope+1], CultureInfo.InvariantCulture);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.Insert(ope - 1, res.ToString());
                    ope -= 2;
                }
            }
        }

        public void AddiSous(List<string> elements)
        {
            for (int ope = 0; ope < elements.Count; ope++)
            {
                double res = 0.0f;
                if (elements[ope] == "+")
                {
                    res = double.Parse(elements[ope - 1], CultureInfo.InvariantCulture) + double.Parse(elements[ope + 1], CultureInfo.InvariantCulture);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.RemoveAt(ope - 1);
                    elements.Insert(ope - 1, res.ToString());
                    ope -= 2;
                }
                else if (elements[ope] == "-")
                {
                    if (ope-1 >= 0)
                    {
                        res = double.Parse(elements[ope - 1], CultureInfo.InvariantCulture) - double.Parse(elements[ope + 1], CultureInfo.InvariantCulture);
                        elements.RemoveAt(ope - 1);
                        elements.RemoveAt(ope - 1);
                        elements.RemoveAt(ope - 1);
                        elements.Insert(ope - 1, res.ToString());
                    }
                    else
                    {
                        res = 0.0f - double.Parse(elements[ope + 1], CultureInfo.InvariantCulture);
                        elements.RemoveAt(ope);
                        elements.RemoveAt(ope);
                        elements.Insert(ope, res.ToString());
                        ope -= 1;
                    }
                }
            }
        }
    }
}
