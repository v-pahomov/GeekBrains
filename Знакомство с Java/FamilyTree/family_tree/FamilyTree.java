package FamilyTree.family_tree;

import FamilyTree.human.Human;
import FamilyTree.human.comparator.HumanComparatorByAge;
import FamilyTree.human.comparator.HumanComparatorByName;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class FamilyTree implements Serializable {
    private long humansId;
    private List<Human> humanList;

    public FamilyTree() {
        this(new ArrayList<>());
    }

    public FamilyTree(List<Human> humanList) {
        this.humanList = humanList;
    }

    public boolean add(Human human) {
        if (human == null) {
            return false;
        }
        if (!humanList.contains(human)) {
            humanList.add(human);
            human.setId(humansId++);

            addToParents(human);
            addToChildren(human);
            return true;
        }
        return false;
    }

    private void addToChildren(Human human) {
        for (Human child : human.getChildren()) {
            child.addParent(human);
        }
    }

    private void addToParents(Human human) {
        for (Human parent : human.getParents()) {
            parent.addChild(human);
        }
    }

    public boolean setWedding(Human human1, Human human2) {
        if (human1.getSpouse() == null && human2.getSpouse() == null) {
            human1.setSpouse(human2);
            human2.setSpouse(human1);
            return true;
        } else {
            return false;
        }
    }

    public void setParentAndChild(Human mother, Human father, Human child) {
        mother.addChild(child);
        father.addChild(child);
        long id = child.getId();
        Human children = removeFromTree(child);
        children.addParent(mother);
        children.addParent(father);
        children.setId(id);
        add(children);
    }

    @Override
    public String toString() {
        return getInfo();
    }

    public String getInfo() {
        StringBuilder sb = new StringBuilder();
        sb.append("В дереве ");
        sb.append(humanList.size());
        sb.append(" объектов: \n");
        for (Human human : humanList) {
            sb.append(human);
            sb.append("\n");
        }
        return sb.toString();
    }
    
    public Human getByName(String name) {
        Human hum = null;
        for (Human human: humanList) {
            if(human.getName().equals(name)){
                hum = human;
            }
        }
        return hum;
    }

    public Human getByID (long id) {
        Human hum = null;
        for (Human human: humanList) {
            if(human.getId() == id){
                hum = human;
            }
        }
        return hum;
    }
    public Human removeFromTree(Human human) {
        Human removeHuman = humanList.get((int) human.getId());
        humanList.remove(human);
        return removeHuman;
    }

    public void sortByName(){
        humanList.sort(new HumanComparatorByName());
    }

    public void sortByAge(){
        humanList.sort(new HumanComparatorByAge());
    }
}
