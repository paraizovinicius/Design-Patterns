public class Program {
    public static void main(String[] args) {
        Builder builder = new PlaneBuilderImpl();
        Plane plane = builder.setModel("LTA500")
                         .setColor("White")
                         .setYear(2021)
                         .setPrice(100000000)
                         .build();
        System.out.println("Model: " + plane.getModel());
        System.out.println("Color: " + plane.getColor());
        System.out.println("Year: " + plane.getYear());
        System.out.println("Price: " + plane.getPrice());
    }
}


