public class Address{
	private String road;
	private String city;
	private String lane;
	private String number;
	private String area;
	public Address(){
		this("台北市","大安區","復興南路二段","","199號");
	}
	public Address(String city,String area,String road,String lane,String number){
		this.city=city;
		this.area=area;
		this.road=road;
		this.lane=lane;
		this.number=number;
	}
	public String getAddress(){
		return city+area+road+lane+number;
	}
}