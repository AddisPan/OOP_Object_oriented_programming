public class Person{
	private Name name;
	private Address address;
	public Person(){
		this(new Name("彭惠君"),new Address("台北市","大安區","復興南路二段","","199號"));		
	}
	public Person(Name name,Address address){
		this.name=name;
		this.address=address;
	}
	public Name getName(){
		return name;
	}
	public void setName(Name name){
		this.name=name;
	}
	public Address getAddress(){
		return address;
	}
	public void setAddress(Address address){
		this.address=address;
	}
	public String toString(){
		return name.getmyname()+'\n'+address.getAddress()+'\n';
	}
}