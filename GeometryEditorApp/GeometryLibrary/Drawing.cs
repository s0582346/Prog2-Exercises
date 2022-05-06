using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MathLibrary;
using GeometryLibrary;

namespace GeometryLibrary
{
    public class Drawing
    {
        protected List<Curve> _curves = new List<Curve>();
        
        public IReadOnlyList<Curve> Curves => _curves.AsReadOnly();


        public Drawing(params Curve[] curves)
        {
            foreach (Curve cur in curves)
            {
                AddCurve(cur);
            }
        }
        public void AddCurve(Curve newCurve)
        {
            _curves.Add(newCurve);  
        }

        public void RemoveCurve(int index)
        {
            _curves.RemoveAt(index);
        }

        public void Draw(Graphics g)
        {
            foreach (Curve cur in _curves)
            {
                cur.Draw(g);
            }
        }
        


    }
}
