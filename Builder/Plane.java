public class Plane {
    private String model;
    private String color;
    private int year;
    private int price;

    public Plane(String model, String color, int year, int price) {
        this.model = model;
        this.color = color;
        this.year = year;
        this.price = price;
    }

    // Métodos getters
    public String getModel() {
        return model;
    }

    public String getColor() {
        return color;
    }

    public int getYear() {
        return year;
    }

    public int getPrice() {
        return price;
    }
}