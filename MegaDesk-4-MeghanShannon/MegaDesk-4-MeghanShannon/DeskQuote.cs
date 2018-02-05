using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MeghanShannon
{
    class DeskQuote
    {
        #region Object member variables
        //A desk quote object description
        private string pCustomerName;
        private DateTime pQuoteDate;
        private Desk PDesk = new Desk();
        private int pRushDays;
        private int pQuoteAmount;
        #endregion

        #region Local variables
        private int pSurfaceArea = 0;
        #endregion

        #region Constants
        //Constants, future source is some data source
        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000; //inches squared
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_SURFACEAREA = 1; //extra cost per square inch greater than desktop size threshold
        private const int RUSH1 = 3; //rush order days options
        private const int RUSH2 = 5; //rush order days options
        private const int RUSH3 = 7; //rush order days options
        private const int RUSH_THRESHOLD = 2000; //inches squared - see problem specs for rush order costs
        #endregion

        public DeskQuote(int width, int depth, int numDrawers, Material material, int rushDays)
        {
            
            /*
             * This class will define the attributes of a quote including Desk, rush days, 
             * customer name, and quote date. This class will also hold the logic in 
             * determining the line item cost.
             */
            //Constructor when object is built - set attribute values

            PDesk.Width = width;
            PDesk.Depth = depth;
            PDesk.NumDrawers = numDrawers;
            PDesk.DesktopMaterial = material;
            pRushDays = rushDays;

            //calculate Surface Area member variable for use in multiple functions
            pSurfaceArea = PDesk.Width * PDesk.Depth;

        }

        public int CalculateQuoteTotal() {
            int surfaceAreaCost = SurfaceAreaCost();
            int drawerCost = DrawerCost();
            int surfaceMaterialCost = (int)PDesk.DesktopMaterial;
            int rushOrderCost = RushOrderCost();
            int total = PRICE_BASE + surfaceAreaCost + drawerCost + surfaceMaterialCost + rushOrderCost;
            return total;
        }

        private int SurfaceAreaCost ()
        {
            //Determine if size of the desk is large enough for an additional charge
            // Determine if additional cost is warranted with desk areas greater than the desktop size threshold
            if (pSurfaceArea > SIZE_THRESHOLD)
            {
                return (pSurfaceArea - SIZE_THRESHOLD) * PRICE_PER_SURFACEAREA;
            }
            else
            {
                return 0;
            }
        }

        private int DrawerCost()
        {
            return PDesk.NumDrawers * PRICE_PER_DRAWER;
        }

        private int RushOrderCost()
        {
            // *** Magic numbers used for costs in this version
            int rushCost = 0;
            if (pRushDays == RUSH1)
            {
                if (pSurfaceArea < SIZE_THRESHOLD)
                {
                    rushCost = 60;
                }
                else if (pSurfaceArea <= RUSH_THRESHOLD)
                {
                    rushCost = 70;
                }
                else
                {
                    rushCost = 80;
                }
            }
            if (pRushDays == RUSH2)
            {
                if (pSurfaceArea < SIZE_THRESHOLD)
                {
                    rushCost = 40;
                }
                else if (pSurfaceArea <= RUSH_THRESHOLD)
                {
                    rushCost = 50;
                }
                else
                {
                    rushCost = 60;
                }
            }
            if (pRushDays == RUSH3)
            {
                if (pSurfaceArea < SIZE_THRESHOLD)
                {
                    rushCost = 30;
                }
                else if (pSurfaceArea <= RUSH_THRESHOLD)
                {
                    rushCost = 30;
                }
                else
                {
                    rushCost = 40;
                }
            }
            return rushCost;
        }
    }
}
