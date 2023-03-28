

public class PlaneBuilderImpl implements Builder {

    private String model;
    private String color;
    private int year;
    private int price;

    @Override //O Override sobrescreve o método já existente Builder
    public Builder setModel(String model) {
        this.model = model;
        return this;
    }

    @Override
    public Builder setColor(String color) {
        this.color = color;
        return this;
    }


    @Override
    public Builder setYear(int year) {
        this.year = year;
        return this;
    }

    @Override
    public Builder setPrice(int price) {
        this.price = price;
        return this;
    }

    @Override
    public Plane build() {
        return new Plane(model, color, year, price);
    }
}



