public interface Builder {
    Builder setModel(String model);
    Builder setColor(String color);
    Builder setYear(int year);
    Builder setPrice(int price);
    Plane build();
}