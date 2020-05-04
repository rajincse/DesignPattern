package Prototype;

public class Demo {
    public static void main(String[] args){
        ShapeCache.loadCache();

        for(int i=1;i<=3;i++)
        {
            Shape shape = ShapeCache.getShape(Integer.toString(i));
            System.out.println("Got shape:"+shape.getType());
        }
    }
}