import java.awt.*;
public class GFrame extends GridBagConstraints 
{
   public GFrame(int gridx, int gridy, int gridwidth, int gridheight)
   {
      this.gridx = gridx;
      this.gridy = gridy;
      this.gridwidth = gridwidth; 
      this.gridheight = gridheight; 
   }
   public GFrame(int gridx, int gridy)
   {
      this.gridx = gridx;
      this.gridy = gridy;
   }
   public GFrame setAnchor(int anchor) 
   { 
      this.anchor = anchor; 
      return this;
   }
   public GFrame setFill(int fill) 
   { 
      this.fill = fill; 
      return this;
   }
   public GFrame setWeight(double weightx, double weighty) 
   { 
      this.weightx = weightx; 
      this.weighty = weighty; 
      return this;
   }
   public GFrame setIpad(int ipadx, int ipady) 
   { 
      this.ipadx = ipadx; 
      this.ipady = ipady; 
      return this;
   }
   public GFrame setInsets(int distance) 
   { 
      this.insets = new Insets(distance, distance, distance, distance);
      return this;
   }
   public GFrame setInsets(int top, int left, int bottom, int right) 
   { 
      this.insets = new Insets(top, left, bottom, right);
      return this;
   }
}

