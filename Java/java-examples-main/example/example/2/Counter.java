public class Counter{
    public static void main(String[] args){      
       Good_words object1=new Good_words("沒有人可以分享的人生 ");
       System.out.println(object1);
       Good_words object2=new Good_words("不二過，孩子第一次犯錯一定要原諒");
       System.out.println(object2); 
       Good_words object3=new Good_words("多做多得，吃虧就是佔便宜。");
       System.out.println(object3); 
       Good_words object4=new Good_words("對自己負責、有餘力照顧別人");
       System.out.println(object4); 
       Good_words object5=new Good_words("今日事今日畢。");
       System.out.println(object5);
       System.out.println("有"+Good_words.getcount()+"個句子");            
    }
}