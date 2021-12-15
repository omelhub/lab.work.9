using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._9
{
    class Checkpoint
    {
        public int Masks { set; get; } = 12;
        public int DisInfections { set; get; } = 21;

        public List<IVisitor> VisitorsWantTo { get; set; } = new List<IVisitor>();
        public List<IVisitor> VisitorsCanTo { get;  } = new List<IVisitor>();

        public void Check()
        {
            foreach (IVisitor visitor in VisitorsWantTo)
            {
                if (visitor is ICanDisinfectHand && visitor is ICanPutOnMask && visitor is IQRCode)
                    //&& вычисляет правый операнд только если это необходимо
                {
                    if (((IQRCode) visitor).IsHaveQR)
                    {
                        if (((ICanPutOnMask)visitor).IsHaveMask)
                        {
                            DisInfections -= 1;
                            VisitorsCanTo.Add(visitor);
                        }
                        else if (Masks > 0)
                        {
                            DisInfections -= 1;
                            Masks -= 1;
                            VisitorsCanTo.Add(visitor);
                        }
                    }
                }
            }

            //foreach (IVisitor aVisitor in VisitorsWantTo)
            //{
            //    foreach (IVisitor bVisitor in VisitorsCanTo)
            //    {
            //        if (aVisitor == bVisitor)
            //            VisitorsWantTo.Remove(aVisitor);
            //    } //чистит список желающих от тех, кого уже одобрили
            //}
        }
    }
}
