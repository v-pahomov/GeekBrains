import java.util.List;
import java.util.Objects;

public class Cat {
    String name;
    String owner;
    String breed;
    int age;
    double weight;
    List<String> healthHostory;

    Cat(String name, String owner, String breed, int age, double weight){
        this.name = name;
        this.owner = owner;
        this.breed = breed;
        this.age = age;
        this.weight = weight;
    }
    

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Cat cat = (Cat) o;
        return age == cat.age && Double.compare(weight, cat.weight) == 0 && Objects.equals(name, cat.name) && Objects.equals(owner, cat.owner) && Objects.equals(breed, cat.breed);
    }

    @Override
    public int hashCode() {
        return Objects.hash(name, owner, breed, age, weight);
    }

    @Override
    public String toString() {
        return "Cat{" +
                "name='" + name + '\'' +
                ", owner='" + owner + '\'' +
                ", breed='" + breed + '\'' +
                ", age=" + age +
                ", weigth=" + weight +
                '}';
    }
}
