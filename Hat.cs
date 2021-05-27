namespace Quest
{
    public class Hat
    {
        //Mutable Porperties
        public int ShininessLevel { get; set; }


        public string ShininessDescription()
        {
            if (ShininessLevel < 2)
            {
                return "dull";
            }
            else if (ShininessLevel >= 2 && ShininessLevel <= 5)
            {
                return "noticeable";
            }
            else if (ShininessLevel >= 6 && ShininessLevel <= 9)
            {
                return "bright";
            }
            else if (ShininessLevel > 9)
            {
                return "blinding";
            }
            else
            {
                return "Non existant";
            }
        }
    }
}