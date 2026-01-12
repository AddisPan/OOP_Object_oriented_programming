public class Depositor extends Person{
	private Asset asset;
	public Depositor(){
		super();
	}
	public Depositor(Name name,Address address){
		super(name,address);
	}
	public Asset getasset(){
		return asset;
	}
	public void setasset(Asset asset){
		this.asset=asset;
	}
	public String toString(){
		return super.toString()+'\n'+"¥»§Q¦X"+asset.payment();
	}
}

