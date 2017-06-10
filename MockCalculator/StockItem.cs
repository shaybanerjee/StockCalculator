namespace StockCalculator
{
    class StockItem
    {
        private double openVal = 0;
        private double highVal = 0;
        private double lowVal = 0;
        private double closeVal = 0;
        private double volumeVal = 0;

        public void setOpen(double val)
        {
            openVal = val;
        }
        public void sethighVal(double val)
        {
            highVal = val;
        }
        public void setlowVal(double val)
        {
            lowVal = val;
        }
        public void setcloseVal(double val)
        {
            closeVal = val;
        }
        public void setvolumeVal(double val)
        {
            volumeVal = val;
        }
        public double getOpenVal()
        {
            return openVal;
        }
        public double getHighVal()
        {
            return highVal;
        }
        public double getLowVal()
        {
            return lowVal;
        }
        public double getCloseVal()
        {
            return closeVal;
        }
        public double getVolVal()
        {
            return volumeVal;
        }
    }
}
