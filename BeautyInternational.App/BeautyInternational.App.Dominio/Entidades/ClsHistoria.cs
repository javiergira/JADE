using System.Collections.Generic;
using System;

namespace BeautyInternational.App.Dominio{
    public class ClsHistoria{
        public int id {get;set;}
        public List<ClsCita> citas = new List<ClsCita>();
    }
}