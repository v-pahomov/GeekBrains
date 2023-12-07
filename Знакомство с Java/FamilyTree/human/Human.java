package FamilyTree.human;

import java.io.Serializable;
import java.time.LocalDate;
import java.time.Period;
import java.util.ArrayList;
import java.util.List;

public class Human implements Serializable {
    private long id;
    private String name;
    private Gender gender;
    private LocalDate birthDate;
    private LocalDate deathDate;
    private Human mother;
    private Human father;
    private List<Human> children;
    private Human spouse;

    public Human(String name, Gender gender, LocalDate birthDate, LocalDate deathDate, Human mother, Human father) {
        id = -1;
        this.name = name;
        this.gender = gender;
        this.birthDate = birthDate;
        this.deathDate = deathDate;
        this.mother = mother;
        this.father = father;
        children = new ArrayList<>();
    }

    public Human(String name, Gender gender, LocalDate birthDate) {
        this(name, gender, birthDate, null, null, null);
    }

    public Human(String name, Gender gender, LocalDate birthDate, Human father, Human mother) {
        this(name, gender, birthDate, null, father, mother);
    }

    public boolean addChild(Human child) {
        if (!children.contains(child)) {
            children.add(child);
            return true;
        }
        return false;
    }

    public boolean addParent(Human parent) {
        if (parent.getGender().equals(Gender.Male)) {
            setFather(parent);
            return true;
        } else if (parent.getGender().equals(Gender.Female)) {
            setMother(parent);
            return true;
        } else {
            return false;
        }
    }

    public Gender getGender() {
        return gender;
    }

    public String getName() { return name; }

    private void setMother(Human mother) {
        this.mother = mother;
    }

    private void setFather(Human father) {
        this.father = father;
    }

    public Human getMother() {
        return mother;
    }

    public Human getFather() {
        return father;
    }

    public void setSpouse(Human spouse) {
        this.spouse = spouse;
    }

    public Human getSpouse() {
        return spouse;
    }

    public List<Human> getParents() {
        List<Human> list = new ArrayList<Human>(2);
        if (father != null) {
            list.add(father);
        }
        if (mother != null) {
            list.add(mother);
        }
        return list;
    }

    public List<Human> getChildren() {
        return children;
    }

    private int getPeriod(LocalDate birthDate, LocalDate deathDate) {
        Period diff = Period.between(birthDate, deathDate);
        return diff.getYears();
    }

    public int getAge() {
        if (deathDate == null) {
            return getPeriod(birthDate, LocalDate.now());
        } else {
            return getPeriod(birthDate, deathDate);
        }
    }

    @Override
    public String toString() {
        return getInfo();
    }

    public String getInfo() {
        StringBuilder sb = new StringBuilder();
        sb.append("id: ");
        sb.append(id);
        sb.append(", имя: ");
        sb.append(name);
        sb.append(", возраст: ");
        sb.append(getAge());
        sb.append(", ");
        sb.append(getSpouseInfo());
        sb.append(", ");
        sb.append(getMotherInfo());
        sb.append(", ");
        sb.append(getFatherInfo());
        sb.append(", ");
        sb.append(getChildrenInfo());
        return sb.toString();
    }

    private String getChildrenInfo() {
        StringBuilder res = new StringBuilder();
        res.append("дети: ");
        if (!children.isEmpty()) {
            res.append(children.get(0).getName());
            for (int i = 1; i < children.size(); i++) {
                res.append(", ");
                res.append(children.get(i).getName());
            }
        } else {
            res.append(" отсутствуют");
        }
        return res.toString();
    }

    private String getFatherInfo() {
        String res = "отец: ";
        if (father != null) {
            res += father.getName();
        } else {
            return "неизвестен";
        }
        return res;
    }

    private String getMotherInfo() {
        String res = "мать: ";
        if (mother != null) {
            res += mother.getName();
        } else {
            return "неизвестна";
        }
        return res;
    }

    private String getSpouseInfo() {
        String res = "супруг(а): ";
        if (spouse == null) {
            return "нет";
        } else {
            res += spouse.getName();
        }
        return res;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj instanceof Human)) {
            return false;
        }
        Human human = (Human) obj;
        return human.getId() == getId();
    }

    private long getId() {
        return id;
    }

    public boolean setId(long id) {
        this.id = id;
        return true;
    }
}
