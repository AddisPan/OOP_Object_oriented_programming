public class WithException {
  private double radius;
  private static int numberOfObjects = 0;
  public WithException() {
    this(8);
  }
  public WithException(double newRadius) {
    setRadius(newRadius);
    numberOfObjects++;
  }
  public double getRadius() {
    return radius;
  }
  public void setRadius(double newRadius)
    throws IllegalArgumentException {
    if (newRadius >= 0)
      radius =  newRadius;
    else
      throw new IllegalArgumentException("輸入參數不能負數");
  }
  public static int getNumberOfObjects() {
    return numberOfObjects;
  }

}
