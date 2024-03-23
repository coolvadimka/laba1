using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba1;
public class graf
{
    public List<graf> Child { get; set; }
    public string Value { get; set; }
    public graf(string value)
    {
        this.Value = value;
        Child = new List<graf>();
    }
    public graf(string value, graf otec)
    {
        this.Value = value;
        this.Child = new List<graf>();
        otec.Child.Add(this);
    }
    public void NewChild(graf rebenok)
    {
        Child.Add(rebenok);
    }
    public void PrintGraf()
    {
        if (Child.Count > 0)
        {
            Console.WriteLine($"Потомки узла {Value}:");
            for (int i = 0; i < Child.Count; i++)
            {
                Console.WriteLine(Child[i].Value);
            }
            for (int i = 0; i < Child.Count; i++)
            {
                Child[i].PrintGraf();
            }
        }
    }
}

