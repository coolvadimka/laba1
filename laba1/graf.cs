using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba1;
public class graf
{
    public List<graf> child { get; set; }
    public string value { get; set; }
    public graf(string value)
    {
        this.value = value;
        child = new List<graf>();
    }
    public graf(string value, graf otec)
    {
        this.value = value;
        this.child = new List<graf>();
        otec.child.Add(this);
    }
    public void NewChild(graf rebenok)
    {
        child.Add(rebenok);
    }
    public void PrintGraf()
    {
        if (child.Count > 0)
        {
            Console.WriteLine($"Потомки узла {value}:");
            for (int i = 0; i < child.Count; i++)
            {
                Console.WriteLine(child[i].value);
            }
            for (int i = 0; i < child.Count; i++)
            {
                child[i].PrintGraf();
            }
        }
    }
}

