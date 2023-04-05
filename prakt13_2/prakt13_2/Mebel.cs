using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace prakt13_2
{
    class Mebel
    {
        private int stoimost;
        private string name;
        private string material;
        private string mesizg;
        private string pokupatel;
        private string adres;
        public Mebel(string name, string material, string mesizg, string pokupatel, string adres)
        {
            this.name = name;
            this.material = material;
            this.mesizg = mesizg;
            this.pokupatel = pokupatel;
            this.adres = adres;
        }
        
        public string getName()
        {
            return this.name;
        }

        public string getMaterial()
        {
            return this.material;
        }

        public string getMesizg()
        {
            return this.mesizg;
        }

        public string getPokupatel()
        {
            return this.pokupatel;
        }

        public string getAdres()
        {
            return this.adres;
        }
        public int getStoimost()
        {
            if (material == "дерево")
            {
                stoimost = 1000;
            }
            else if (material == "железо")
            {
                stoimost = 3000;
            }
            else if (material == "пластик")
            {
                stoimost = 400;
            }
            else if (material == "стекло")
            {
                stoimost = 4000;
            }
            else stoimost = 400;
            return stoimost;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setMaterial(string material)
        {
            this.material = material;
        }
        public void setMesizg(string quantity)
        {
            this.mesizg = quantity;
        }
        public void setPokupatel(string pokupatel)
        {
            this.pokupatel = pokupatel;
        }
        public void setAdres(string adres)
        {
            this.adres = adres;
        }

        public void setStoimost(int stoimost)
        {
            this.stoimost = stoimost;
        }

    }
}
