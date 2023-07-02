using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintOrder : MonoBehaviour
{
    public Text orderText;
    public int red;
    public int green;
    public int blue;
    public int count;
    public string colorName;
    public bool orderCreated;
    public float delay;
    public int paintRange;

    void Start()
    {
        noOrder();
        paintRange = 255;
    }
    public void addMorePaints()
    {
        if (paintRange + 255 > 938)
        {
            paintRange = 938;
        }
        else
        {
            paintRange += 255;
        }
    }
    public int GetPaintRange()
    {
        return paintRange;
    }
    public void setPaintRange(int paintRange)
    {
        this.paintRange = paintRange;
    }
    public int getRed()
    {
        return red;
    }
    public int getGreen()
    {
        return green;
    }
    public int getBlue()
    {
        return blue;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            CreateOrder();
        }
    }
    public void getOrder()
    {
        orderText.text = ("Paint Name: \n" + colorName + "\nRed Needed:\n" + red + "\nGreen Needed:\n" + green + "\nBlue Needed:\n" + blue);
    }

    public void noOrder()
    {
        red = -99;
        green = -99;
        blue = -99;
        orderText.text = ("No available orders to complete");
    }
    public void CreateOrder()
    {
        count = Random.Range(1,paintRange);   
            if (count == 1)
                {
                    colorName = "Beluga";
                    orderCreated = true;
                    red = 9;
                    green = 48;
                    blue = 49;
                }
            else if (count == 2)
                {
                    colorName = "Bauhaus";
                    orderCreated = true;
                    red = 43;
                    green = 52;
                    blue = 57;
                }
            else if (count == 3)
                {
                    colorName = "Deep Forest";
                    orderCreated = true;
                    red = 48;
                    green = 66;
                    blue = 48;
                }
            else if (count == 4)
                {
                    colorName = "Black Swan";
                    orderCreated = true;
                    red = 50;
                    green = 64;
                    blue = 56;
                }
            else if (count == 5)
                {
                    colorName = "Rich Bordeaux";
                    orderCreated = true;
                    red = 60;
                    green = 50;
                    blue = 61;
                }
            else if (count == 6)
                {
                    colorName = "Peaceful Night";
                    orderCreated = true;
                    red = 29;
                    green = 53;
                    blue = 92;
                }
            else if (count == 7)
                {
                    colorName = "Catwalk";
                    orderCreated = true;
                    red = 52;
                    green = 57;
                    blue = 68;
                }
            else if (count == 8)
                {
                    colorName = "Dried Leaf";
                    orderCreated = true;
                    red = 69;
                    green = 63;
                    blue = 47;
                }
            else if (count == 9)
                {
                    colorName = "Madison Avenue";
                    orderCreated = true;
                    red = 60;
                    green = 61;
                    blue = 61;
                }
            else if (count == 10)
                {
                    colorName = "Ink Black";
                    orderCreated = true;
                    red = 47;
                    green = 62;
                    blue = 74;
                }
            else if (count == 11)
                {
                    colorName = "Warm Brownie";
                    orderCreated = true;
                    red = 77;
                    green = 54;
                    blue = 55;
                }
            else if (count == 12)
                {
                    colorName = "Baritone";
                    orderCreated = true;
                    red = 60;
                    green = 48;
                    blue = 79;
                }
            else if (count == 13)
                {
                    colorName = "Mayan Red";
                    orderCreated = true;
                    red = 86;
                    green = 50;
                    blue = 52;
                }
            else if (count == 14)
                {
                    colorName = "English Manor";
                    orderCreated = true;
                    red = 74;
                    green = 56;
                    blue = 59;
                }
            else if (count == 15)
                {
                    colorName = "Florence Red";
                    orderCreated = true;
                    red = 101;
                    green = 39;
                    blue = 50;
                }
            else if (count == 16)
                {
                    colorName = "Fedora";
                    orderCreated = true;
                    red = 66;
                    green = 68;
                    blue = 56;
                }
            else if (count == 17)
                {
                    colorName = "Lunar Eclipse";
                    orderCreated = true;
                    red = 37;
                    green = 45;
                    blue = 109;
                }
            else if (count == 18)
                {
                    colorName = "Mahogany Spice";
                    orderCreated = true;
                    red = 71;
                    green = 54;
                    blue = 67;
                }
            else if (count == 19)
                {
                    colorName = "Jolly Green";
                    orderCreated = true;
                    red = 46;
                    green = 87;
                    blue = 60;
                }
            else if (count == 20)
                {
                    colorName = "Fireside";
                    orderCreated = true;
                    red = 89;
                    green = 50;
                    blue = 55;
                }
            else if (count == 21)
                {
                    colorName = "Forest Ridge";
                    orderCreated = true;
                    red = 62;
                    green = 90;
                    blue = 44;
                }
            else if (count == 22)
                {
                    colorName = "Billiard Table";
                    orderCreated = true;
                    red = 18;
                    green = 109;
                    blue = 69;
                }
            else if (count == 23)
                {
                    colorName = "French Roast";
                    orderCreated = true;
                    red = 73;
                    green = 65;
                    blue = 59;
                }
            else if (count == 24)
                {
                    colorName = "Potting Soil";
                    orderCreated = true;
                    red = 69;
                    green = 72;
                    blue = 58;
                }
            else if (count == 25)
                {
                    colorName = "Black Elegance";
                    orderCreated = true;
                    red = 60;
                    green = 63;
                    blue = 77;
                }
            else if (count == 26)
                {
                    colorName = "Chocolate Cupcake";
                    orderCreated = true;
                    red = 75;
                    green = 73;
                    blue = 54;
                }
            else if (count == 27)
                {
                    colorName = "Space Black";
                    orderCreated = true;
                    red = 58;
                    green = 72;
                    blue = 73;
                }
            else if (count == 28)
                {
                    colorName = "Burley Wood";
                    orderCreated = true;
                    red = 86;
                    green = 71;
                    blue = 46;
                }
            else if (count == 29)
                {
                    colorName = "Luck Of The Irish";
                    orderCreated = true;
                    red = 63;
                    green = 140;
                    blue = 2;
                }
            else if (count == 30)
                {
                    colorName = "Sarsaparilla";
                    orderCreated = true;
                    red = 74;
                    green = 65;
                    blue = 67;
                }
            else if (count == 31)
                {
                    colorName = "Deep Mulberry";
                    orderCreated = true;
                    red = 60;
                    green = 57;
                    blue = 90;
                }
            else if (count == 32)
                {
                    colorName = "Kingfisher";
                    orderCreated = true;
                    red = 34;
                    green = 81;
                    blue = 93;
                }
            else if (count == 33)
                {
                    colorName = "Navy Blue";
                    orderCreated = true;
                    red = 11;
                    green = 47;
                    blue = 151;
                }
            else if (count == 34)
                {
                    colorName = "Stone Hearth";
                    orderCreated = true;
                    red = 70;
                    green = 71;
                    blue = 69;
                }
            else if (count == 35)
                {
                    colorName = "Tropical Skies";
                    orderCreated = true;
                    red = 16;
                    green = 97;
                    blue = 97;
                }
            else if (count == 36)
                {
                    colorName = "Plum";
                    orderCreated = true;
                    red = 57;
                    green = 43;
                    blue = 111;
                }
            else if (count == 37)
                {
                    colorName = "Red Brick";
                    orderCreated = true;
                    red = 116;
                    green = 40;
                    blue = 56;
                }
            else if (count == 38)
                {
                    colorName = "Awning Red";
                    orderCreated = true;
                    red = 128;
                    green = 33;
                    blue = 52;
                }
            else if (count == 39)
                {
                    colorName = "Deep Merlot";
                    orderCreated = true;
                    red = 63;
                    green = 54;
                    blue = 97;
                }
            else if (count == 40)
                {
                    colorName = "Rave Raisin";
                    orderCreated = true;
                    red = 83;
                    green = 69;
                    blue = 63;
                }
            else if (count == 41)
                {
                    colorName = "Chlorophyll";
                    orderCreated = true;
                    red = 30;
                    green = 174;
                    blue = 12;
                }
            else if (count == 42)
                {
                    colorName = "Earth Fired Red";
                    orderCreated = true;
                    red = 103;
                    green = 64;
                    blue = 49;
                }
            else if (count == 43)
                {
                    colorName = "July Ruby";
                    orderCreated = true;
                    red = 102;
                    green = 31;
                    blue = 84;
                }
            else if (count == 44)
                {
                    colorName = "Catskill Brown";
                    orderCreated = true;
                    red = 68;
                    green = 74;
                    blue = 76;
                }
            else if (count == 45)
                {
                    colorName = "North Woods";
                    orderCreated = true;
                    red = 63;
                    green = 86;
                    blue = 69;
                }
            else if (count == 46)
                {
                    colorName = "Starless Night";
                    orderCreated = true;
                    red = 62;
                    green = 72;
                    blue = 85;
                }
            else if (count == 47)
                {
                    colorName = "Red Red Red";
                    orderCreated = true;
                    red = 134;
                    green = 34;
                    blue = 52;
                }
            else if (count == 48)
                {
                    colorName = "Toasted Pecan";
                    orderCreated = true;
                    red = 101;
                    green = 63;
                    blue = 56;
                }
            else if (count == 49)
                {
                    colorName = "Manhattan Blue";
                    orderCreated = true;
                    red = 64;
                    green = 67;
                    blue = 90;
                }
            else if (count == 50)
                {
                    colorName = "Ruby Red";
                    orderCreated = true;
                    red = 112;
                    green = 28;
                    blue = 82;
                }
            else if (count == 51)
                {
                    colorName = "Deco Red";
                    orderCreated = true;
                    red = 115;
                    green = 47;
                    blue = 60;
                }
            else if (count == 52)
                {
                    colorName = "Pasture Green";
                    orderCreated = true;
                    red = 60;
                    green = 101;
                    blue = 63;
                }
            else if (count == 53)
                {
                    colorName = "Silken Pine";
                    orderCreated = true;
                    red = 51;
                    green = 92;
                    blue = 82;
                }
            else if (count == 54)
                {
                    colorName = "Chipotle Paste";
                    orderCreated = true;
                    red = 104;
                    green = 62;
                    blue = 59;
                }
            else if (count == 55)
                {
                    colorName = "Timber Brown";
                    orderCreated = true;
                    red = 76;
                    green = 75;
                    blue = 75;
                }
            else if (count == 56)
                {
                    colorName = "Napa Wine";
                    orderCreated = true;
                    red = 91;
                    green = 63;
                    blue = 72;
                }
            else if (count == 57)
                {
                    colorName = "Sovereign";
                    orderCreated = true;
                    red = 74;
                    green = 66;
                    blue = 87;
                }
            else if (count == 58)
                {
                    colorName = "Harvest Oak";
                    orderCreated = true;
                    red = 82;
                    green = 74;
                    blue = 72;
                }
            else if (count == 59)
                {
                    colorName = "Black Bamboo";
                    orderCreated = true;
                    red = 71;
                    green = 87;
                    blue = 71;
                }
            else if (count == 60)
                {
                    colorName = "Mystical Shade";
                    orderCreated = true;
                    red = 50;
                    green = 70;
                    blue = 110;
                }
            else if (count == 61)
                {
                    colorName = "Jungle Trail";
                    orderCreated = true;
                    red = 88;
                    green = 116;
                    blue = 27;
                }
            else if (count == 62)
                {
                    colorName = "Rare Wood";
                    orderCreated = true;
                    red = 88;
                    green = 76;
                    blue = 68;
                }
            else if (count == 63)
                {
                    colorName = "Green Grass";
                    orderCreated = true;
                    red = 43;
                    green = 172;
                    blue = 18;
                }
            else if (count == 64)
                {
                    colorName = "Maharaja";
                    orderCreated = true;
                    red = 54;
                    green = 69;
                    blue = 111;
                }
            else if (count == 65)
                {
                    colorName = "Cedar Glen";
                    orderCreated = true;
                    red = 86;
                    green = 101;
                    blue = 47;
                }
            else if (count == 66)
                {
                    colorName = "Green Mallard";
                    orderCreated = true;
                    red = 49;
                    green = 97;
                    blue = 89;
                }
            else if (count == 67)
                {
                    colorName = "Violet Eclipse";
                    orderCreated = true;
                    red = 59;
                    green = 63;
                    blue = 114;
                }
            else if (count == 68)
                {
                    colorName = "Vixen";
                    orderCreated = true;
                    red = 91;
                    green = 64;
                    blue = 81;
                }
            else if (count == 69)
                {
                    colorName = "Roasted Nuts";
                    orderCreated = true;
                    red = 94;
                    green = 76;
                    blue = 66;
                }
            else if (count == 70)
                {
                    colorName = "Abysse";
                    orderCreated = true;
                    red = 61;
                    green = 87;
                    blue = 89;
                }
            else if (count == 71)
                {
                    colorName = "Academy Purple";
                    orderCreated = true;
                    red = 54;
                    green = 66;
                    blue = 118;
                }
            else if (count == 72)
                {
                    colorName = "Earth Chicory";
                    orderCreated = true;
                    red = 100;
                    green = 74;
                    blue = 64;
                }
            else if (count == 73)
                {
                    colorName = "Red Tomato";
                    orderCreated = true;
                    red = 174;
                    green = 27;
                    blue = 39;
                }
            else if (count == 74)
                {
                    colorName = "Classic Cherry";
                    orderCreated = true;
                    red = 140;
                    green = 31;
                    blue = 70;
                }
            else if (count == 75)
                {
                    colorName = "New Penny";
                    orderCreated = true;
                    red = 157;
                    green = 49;
                    blue = 35;
                }
            else if (count == 76)
                {
                    colorName = "Cabin In The Woods";
                    orderCreated = true;
                    red = 92;
                    green = 77;
                    blue = 73;
                }
            else if (count == 77)
                {
                    colorName = "Red Pepper";
                    orderCreated = true;
                    red = 122;
                    green = 63;
                    blue = 57;
                }
            else if (count == 78)
                {
                    colorName = "Par Four Green";
                    orderCreated = true;
                    red = 50;
                    green = 193;
                    blue = 0;
                }
            else if (count == 79)
                {
                    colorName = "Spanish Leather";
                    orderCreated = true;
                    red = 129;
                    green = 89;
                    blue = 26;
                }
            else if (count == 80)
                {
                    colorName = "Grand Plum";
                    orderCreated = true;
                    red = 87;
                    green = 71;
                    blue = 86;
                }
            else if (count == 81)
                {
                    colorName = "True Copper";
                    orderCreated = true;
                    red = 126;
                    green = 64;
                    blue = 54;
                }
            else if (count == 82)
                {
                    colorName = "Brown Ridge";
                    orderCreated = true;
                    red = 97;
                    green = 72;
                    blue = 77;
                }
            else if (count == 83)
                {
                    colorName = "Sequoia Dusk";
                    orderCreated = true;
                    red = 102;
                    green = 68;
                    blue = 77;
                }
            else if (count == 84)
                {
                    colorName = "Dozen Roses";
                    orderCreated = true;
                    red = 126;
                    green = 60;
                    blue = 61;
                }
            else if (count == 85)
                {
                    colorName = "Park Picnic";
                    orderCreated = true;
                    red = 53;
                    green = 188;
                    blue = 7;
                }
            else if (count == 86)
                {
                    colorName = "Moss Landing";
                    orderCreated = true;
                    red = 90;
                    green = 140;
                    blue = 19;
                }
            else if (count == 87)
                {
                    colorName = "Dressed To Impress";
                    orderCreated = true;
                    red = 114;
                    green = 70;
                    blue = 65;
                }
            else if (count == 88)
                {
                    colorName = "Haunting Melody";
                    orderCreated = true;
                    red = 113;
                    green = 42;
                    blue = 95;
                }
            else if (count == 89)
                {
                    colorName = "Marsh Grass";
                    orderCreated = true;
                    red = 114;
                    green = 118;
                    blue = 19;
                }
            else if (count == 90)
                {
                    colorName = "Plum Jam";
                    orderCreated = true;
                    red = 97;
                    green = 38;
                    blue = 117;
                }
            else if (count == 91)
                {
                    colorName = "Boston Brick";
                    orderCreated = true;
                    red = 121;
                    green = 58;
                    blue = 74;
                }
            else if (count == 92)
                {
                    colorName = "Adventurer";
                    orderCreated = true;
                    red = 96;
                    green = 95;
                    blue = 62;
                }
            else if (count == 93)
                {
                    colorName = "Summer Heat";
                    orderCreated = true;
                    red = 165;
                    green = 59;
                    blue = 29;
                }
            else if (count == 94)
                {
                    colorName = "Sultana";
                    orderCreated = true;
                    red = 76;
                    green = 44;
                    blue = 134;
                }
            else if (count == 95)
                {
                    colorName = "Daredevil";
                    orderCreated = true;
                    red = 170;
                    green = 29;
                    blue = 56;
                }
            else if (count == 96)
                {
                    colorName = "Urban Legend";
                    orderCreated = true;
                    red = 82;
                    green = 74;
                    blue = 100;
                }
            else if (count == 97)
                {
                    colorName = "Maroon";
                    orderCreated = true;
                    red = 102;
                    green = 51;
                    blue = 104;
                }
            else if (count == 98)
                {
                    colorName = "Paramount";
                    orderCreated = true;
                    red = 70;
                    green = 93;
                    blue = 94;
                }
            else if (count == 99)
                {
                    colorName = "Maximum Gray";
                    orderCreated = true;
                    red = 85;
                    green = 86;
                    blue = 87;
                }
            else if (count == 100)
                {
                    colorName = "Formal Maroon";
                    orderCreated = true;
                    red = 112;
                    green = 71;
                    blue = 76;
                }
            else if (count == 101)
                {
                    colorName = "Whispering Pine";
                    orderCreated = true;
                    red = 74;
                    green = 113;
                    blue = 73;
                }
            else if (count == 102)
                {
                    colorName = "Folk Guitar";
                    orderCreated = true;
                    red = 105;
                    green = 90;
                    blue = 65;
                }
            else if (count == 103)
                {
                    colorName = "Painted Turtle";
                    orderCreated = true;
                    red = 77;
                    green = 102;
                    blue = 82;
                }
            else if (count == 104)
                {
                    colorName = "Lemon Pepper";
                    orderCreated = true;
                    red = 103;
                    green = 100;
                    blue = 59;
                }
            else if (count == 105)
                {
                    colorName = "Frosted Pomegranate";
                    orderCreated = true;
                    red = 173;
                    green = 21;
                    blue = 69;
                }
            else if (count == 106)
                {
                    colorName = "New Sled";
                    orderCreated = true;
                    red = 146;
                    green = 58;
                    blue = 60;
                }
            else if (count == 107)
                {
                    colorName = "100 Mph";
                    orderCreated = true;
                    red = 206;
                    green = 23;
                    blue = 35;
                }
            else if (count == 108)
                {
                    colorName = "Voodoo";
                    orderCreated = true;
                    red = 71;
                    green = 79;
                    blue = 114;
                }
            else if (count == 109)
                {
                    colorName = "Sassy Grass";
                    orderCreated = true;
                    red = 103;
                    green = 162;
                    blue = 0;
                }
            else if (count == 110)
                {
                    colorName = "Radicchio";
                    orderCreated = true;
                    red = 93;
                    green = 53;
                    blue = 120;
                }
            else if (count == 111)
                {
                    colorName = "Striking";
                    orderCreated = true;
                    red = 19;
                    green = 112;
                    blue = 135;
                }
            else if (count == 112)
                {
                    colorName = "Wild Mushroom";
                    orderCreated = true;
                    red = 115;
                    green = 105;
                    blue = 47;
                }
            else if (count == 113)
                {
                    colorName = "Allure";
                    orderCreated = true;
                    red = 140;
                    green = 66;
                    blue = 61;
                }
            else if (count == 114)
                {
                    colorName = "Nostalgic Evening";
                    orderCreated = true;
                    red = 50;
                    green = 99;
                    blue = 119;
                }
            else if (count == 115)
                {
                    colorName = "Alligator Skin";
                    orderCreated = true;
                    red = 100;
                    green = 95;
                    blue = 73;
                }
            else if (count == 116)
                {
                    colorName = "Deep Orchid";
                    orderCreated = true;
                    red = 54;
                    green = 65;
                    blue = 150;
                }
            else if (count == 117)
                {
                    colorName = "Secret Meadow";
                    orderCreated = true;
                    red = 95;
                    green = 123;
                    blue = 51;
                }
            else if (count == 118)
                {
                    colorName = "Illusionist";
                    orderCreated = true;
                    red = 87;
                    green = 79;
                    blue = 104;
                }
            else if (count == 119)
                {
                    colorName = "Solitude";
                    orderCreated = true;
                    red = 55;
                    green = 111;
                    blue = 105;
                }
            else if (count == 120)
                {
                    colorName = "Pinecone Hill";
                    orderCreated = true;
                    red = 79;
                    green = 106;
                    blue = 86;
                }
            else if (count == 121)
                {
                    colorName = "Thai Curry";
                    orderCreated = true;
                    red = 136;
                    green = 124;
                    blue = 12;
                }
            else if (count == 122)
                {
                    colorName = "Tree Hugger";
                    orderCreated = true;
                    red = 103;
                    green = 124;
                    blue = 45;
                }
            else if (count == 123)
                {
                    colorName = "Caramelized Orange";
                    orderCreated = true;
                    red = 178;
                    green = 74;
                    blue = 22;
                }
            else if (count == 124)
                {
                    colorName = "Underwater";
                    orderCreated = true;
                    red = 78;
                    green = 97;
                    blue = 99;
                }
            else if (count == 125)
                {
                    colorName = "Mondrian Blue";
                    orderCreated = true;
                    red = 15;
                    green = 104;
                    blue = 156;
                }
            else if (count == 126)
                {
                    colorName = "Book Binder";
                    orderCreated = true;
                    red = 112;
                    green = 74;
                    blue = 90;
                }
            else if (count == 127)
                {
                    colorName = "Dark Cobalt Blue";
                    orderCreated = true;
                    red = 50;
                    green = 87;
                    blue = 139;
                }
            else if (count == 128)
                {
                    colorName = "Mayan Gold";
                    orderCreated = true;
                    red = 160;
                    green = 102;
                    blue = 15;
                }
            else if (count == 129)
                {
                    colorName = "Morocco Red";
                    orderCreated = true;
                    red = 150;
                    green = 68;
                    blue = 59;
                }
            else if (count == 130)
                {
                    colorName = "Victorian Gold";
                    orderCreated = true;
                    red = 151;
                    green = 113;
                    blue = 14;
                }
            else if (count == 131)
                {
                    colorName = "Traditional Blue";
                    orderCreated = true;
                    red = 31;
                    green = 101;
                    blue = 146;
                }
            else if (count == 132)
                {
                    colorName = "Deer Trail";
                    orderCreated = true;
                    red = 105;
                    green = 98;
                    blue = 76;
                }
            else if (count == 133)
                {
                    colorName = "Caribe";
                    orderCreated = true;
                    red = 18;
                    green = 125;
                    blue = 136;
                }
            else if (count == 134)
                {
                    colorName = "Coconut Husk";
                    orderCreated = true;
                    red = 102;
                    green = 105;
                    blue = 73;
                }
            else if (count == 135)
                {
                    colorName = "Pencil Point";
                    orderCreated = true;
                    red = 89;
                    green = 93;
                    blue = 98;
                }
            else if (count == 136)
                {
                    colorName = "African Plain";
                    orderCreated = true;
                    red = 120;
                    green = 109;
                    blue = 51;
                }
            else if (count == 137)
                {
                    colorName = "Colorful Leaves";
                    orderCreated = true;
                    red = 166;
                    green = 64;
                    blue = 51;
                }
            else if (count == 138)
                {
                    colorName = "Green Acres";
                    orderCreated = true;
                    red = 66;
                    green = 215;
                    blue = 0;
                }
            else if (count == 139)
                {
                    colorName = "Flashy Sapphire";
                    orderCreated = true;
                    red = 18;
                    green = 65;
                    blue = 199;
                }
            else if (count == 140)
                {
                    colorName = "Meteorological";
                    orderCreated = true;
                    red = 69;
                    green = 115;
                    blue = 99;
                }
            else if (count == 141)
                {
                    colorName = "Ice Cave";
                    orderCreated = true;
                    red = 31;
                    green = 110;
                    blue = 143;
                }
            else if (count == 142)
                {
                    colorName = "Legacy";
                    orderCreated = true;
                    red = 92;
                    green = 89;
                    blue = 103;
                }
            else if (count == 143)
                {
                    colorName = "Mermaid Sea";
                    orderCreated = true;
                    red = 39;
                    green = 161;
                    blue = 85;
                }
            else if (count == 144)
                {
                    colorName = "Red My Mind";
                    orderCreated = true;
                    red = 152;
                    green = 67;
                    blue = 67;
                }
            else if (count == 145)
                {
                    colorName = "Bistro";
                    orderCreated = true;
                    red = 113;
                    green = 90;
                    blue = 84;
                }
            else if (count == 146)
                {
                    colorName = "Sapphire Lace";
                    orderCreated = true;
                    red = 13;
                    green = 77;
                    blue = 197;
                }
            else if (count == 147)
                {
                    colorName = "Mood Indigo";
                    orderCreated = true;
                    red = 60;
                    green = 99;
                    blue = 129;
                }
            else if (count == 148)
                {
                    colorName = "Tiger Stripe";
                    orderCreated = true;
                    red = 190;
                    green = 84;
                    blue = 14;
                }
            else if (count == 149)
                {
                    colorName = "Raw Sienna";
                    orderCreated = true;
                    red = 130;
                    green = 81;
                    blue = 78;
                }
            else if (count == 150)
                {
                    colorName = "Fire Island";
                    orderCreated = true;
                    red = 227;
                    green = 39;
                    blue = 24;
                }
            else if (count == 151)
                {
                    colorName = "Preservation Plum";
                    orderCreated = true;
                    red = 101;
                    green = 88;
                    blue = 101;
                }
            else if (count == 152)
                {
                    colorName = "Mesmerize";
                    orderCreated = true;
                    red = 55;
                    green = 92;
                    blue = 144;
                }
            else if (count == 153)
                {
                    colorName = "Willow Leaf";
                    orderCreated = true;
                    red = 96;
                    green = 110;
                    blue = 85;
                }
            else if (count == 154)
                {
                    colorName = "Spiced Latte";
                    orderCreated = true;
                    red = 120;
                    green = 99;
                    blue = 73;
                }
            else if (count == 155)
                {
                    colorName = "Royal Orchard";
                    orderCreated = true;
                    red = 95;
                    green = 108;
                    blue = 90;
                }
            else if (count == 156)
                {
                    colorName = "Burnished Bronze";
                    orderCreated = true;
                    red = 142;
                    green = 123;
                    blue = 29;
                }
            else if (count == 157)
                {
                    colorName = "Dusty Mountain";
                    orderCreated = true;
                    red = 96;
                    green = 108;
                    blue = 91;
                }
            else if (count == 158)
                {
                    colorName = "Autumn Fest";
                    orderCreated = true;
                    red = 186;
                    green = 109;
                    blue = 0;
                }
            else if (count == 159)
                {
                    colorName = "Fine Burgundy";
                    orderCreated = true;
                    red = 128;
                    green = 80;
                    blue = 89;
                }
            else if (count == 160)
                {
                    colorName = "Rose Garland";
                    orderCreated = true;
                    red = 119;
                    green = 65;
                    blue = 114;
                }
            else if (count == 161)
                {
                    colorName = "Deep Fire";
                    orderCreated = true;
                    red = 193;
                    green = 58;
                    blue = 47;
                }
            else if (count == 162)
                {
                    colorName = "Powdered Brick";
                    orderCreated = true;
                    red = 148;
                    green = 80;
                    blue = 70;
                }
            else if (count == 163)
                {
                    colorName = "Arts And Crafts";
                    orderCreated = true;
                    red = 125;
                    green = 100;
                    blue = 74;
                }
            else if (count == 164)
                {
                    colorName = "Dark Granite";
                    orderCreated = true;
                    red = 90;
                    green = 107;
                    blue = 104;
                }
            else if (count == 165)
                {
                    colorName = "Peppergrass";
                    orderCreated = true;
                    red = 101;
                    green = 117;
                    blue = 83;
                }
            else if (count == 166)
                {
                    colorName = "Chelsea Garden";
                    orderCreated = true;
                    red = 85;
                    green = 111;
                    blue = 106;
                }
            else if (count == 167)
                {
                    colorName = "Exotic Honey";
                    orderCreated = true;
                    red = 195;
                    green = 108;
                    blue = 0;
                }
            else if (count == 168)
                {
                    colorName = "Euphoric Magenta";
                    orderCreated = true;
                    red = 107;
                    green = 64;
                    blue = 133;
                }
            else if (count == 169)
                {
                    colorName = "Classic Berry";
                    orderCreated = true;
                    red = 124;
                    green = 82;
                    blue = 98;
                }
            else if (count == 170)
                {
                    colorName = "Park Bench";
                    orderCreated = true;
                    red = 67;
                    green = 149;
                    blue = 89;
                }
            else if (count == 171)
                {
                    colorName = "Mosaic Blue";
                    orderCreated = true;
                    red = 71;
                    green = 99;
                    blue = 135;
                }
            else if (count == 172)
                {
                    colorName = "Garden Sprout";
                    orderCreated = true;
                    red = 160;
                    green = 130;
                    blue = 15;
                }
            else if (count == 173)
                {
                    colorName = "Gray Owl";
                    orderCreated = true;
                    red = 100;
                    green = 108;
                    blue = 98;
                }
            else if (count == 174)
                {
                    colorName = "Arabian Veil";
                    orderCreated = true;
                    red = 105;
                    green = 100;
                    blue = 101;
                }
            else if (count == 175)
                {
                    colorName = "Crantini";
                    orderCreated = true;
                    red = 149;
                    green = 76;
                    blue = 82;
                }
            else if (count == 176)
                {
                    colorName = "Whiskey Barrel";
                    orderCreated = true;
                    red = 118;
                    green = 105;
                    blue = 85;
                }
            else if (count == 177)
                {
                    colorName = "Gem";
                    orderCreated = true;
                    red = 45;
                    green = 72;
                    blue = 191;
                }
            else if (count == 178)
                {
                    colorName = "Scallion";
                    orderCreated = true;
                    red = 102;
                    green = 118;
                    blue = 89;
                }
            else if (count == 179)
                {
                    colorName = "Violet Evening";
                    orderCreated = true;
                    red = 78;
                    green = 95;
                    blue = 137;
                }
            else if (count == 180)
                {
                    colorName = "Pepper Grass";
                    orderCreated = true;
                    red = 108;
                    green = 196;
                    blue = 7;
                }
            else if (count == 181)
                {
                    colorName = "Secret Journal";
                    orderCreated = true;
                    red = 125;
                    green = 97;
                    blue = 89;
                }
            else if (count == 182)
                {
                    colorName = "Seven Seas";
                    orderCreated = true;
                    red = 46;
                    green = 115;
                    blue = 151;
                }
            else if (count == 183)
                {
                    colorName = "Purple Sky";
                    orderCreated = true;
                    red = 98;
                    green = 85;
                    blue = 129;
                }
            else if (count == 184)
                {
                    colorName = "Sophisticated Teal";
                    orderCreated = true;
                    red = 83;
                    green = 112;
                    blue = 118;
                }
            else if (count == 185)
                {
                    colorName = "Lingonberry Punch";
                    orderCreated = true;
                    red = 164;
                    green = 55;
                    blue = 95;
                }
            else if (count == 186)
                {
                    colorName = "Nypd";
                    orderCreated = true;
                    red = 74;
                    green = 112;
                    blue = 129;
                }
            else if (count == 187)
                {
                    colorName = "Timeless Copper";
                    orderCreated = true;
                    red = 140;
                    green = 94;
                    blue = 81;
                }
            else if (count == 188)
                {
                    colorName = "Kindling";
                    orderCreated = true;
                    red = 105;
                    green = 110;
                    blue = 101;
                }
            else if (count == 189)
                {
                    colorName = "Mexican Chile";
                    orderCreated = true;
                    red = 189;
                    green = 61;
                    blue = 67;
                }
            else if (count == 190)
                {
                    colorName = "Perfect Penny";
                    orderCreated = true;
                    red = 151;
                    green = 87;
                    blue = 79;
                }
            else if (count == 191)
                {
                    colorName = "Napa Winery";
                    orderCreated = true;
                    red = 81;
                    green = 75;
                    blue = 162;
                }
            else if (count == 192)
                {
                    colorName = "Medieval Gold";
                    orderCreated = true;
                    red = 164;
                    green = 117;
                    blue = 38;
                }
            else if (count == 193)
                {
                    colorName = "Rich Brocade";
                    orderCreated = true;
                    red = 147;
                    green = 89;
                    blue = 83;
                }
            else if (count == 194)
                {
                    colorName = "Myth";
                    orderCreated = true;
                    red = 81;
                    green = 117;
                    blue = 122;
                }
            else if (count == 195)
                {
                    colorName = "Earth Tone";
                    orderCreated = true;
                    red = 153;
                    green = 93;
                    blue = 75;
                }
            else if (count == 196)
                {
                    colorName = "Cameroon Green";
                    orderCreated = true;
                    red = 96;
                    green = 116;
                    blue = 109;
                }
            else if (count == 197)
                {
                    colorName = "Pepper Mill";
                    orderCreated = true;
                    red = 104;
                    green = 119;
                    blue = 99;
                }
            else if (count == 198)
                {
                    colorName = "Pottery Red";
                    orderCreated = true;
                    red = 171;
                    green = 61;
                    blue = 91;
                }
            else if (count == 199)
                {
                    colorName = "Dark Room";
                    orderCreated = true;
                    red = 77;
                    green = 108;
                    blue = 138;
                }
            else if (count == 200)
                {
                    colorName = "Mint Sprig";
                    orderCreated = true;
                    red = 42;
                    green = 215;
                    blue = 66;
                }
            else if (count == 201)
                {
                    colorName = "Bubble Turquoise";
                    orderCreated = true;
                    red = 55;
                    green = 156;
                    blue = 113;
                }
            else if (count == 202)
                {
                    colorName = "Forest Edge";
                    orderCreated = true;
                    red = 81;
                    green = 135;
                    blue = 108;
                }
            else if (count == 203)
                {
                    colorName = "Fall Leaves";
                    orderCreated = true;
                    red = 195;
                    green = 104;
                    blue = 27;
                }
            else if (count == 204)
                {
                    colorName = "Glazed Raspberry";
                    orderCreated = true;
                    red = 161;
                    green = 40;
                    blue = 126;
                }
            else if (count == 205)
                {
                    colorName = "Scotland Isle";
                    orderCreated = true;
                    red = 120;
                    green = 172;
                    blue = 36;
                }
            else if (count == 206)
                {
                    colorName = "Terrain";
                    orderCreated = true;
                    red = 111;
                    green = 129;
                    blue = 89;
                }
            else if (count == 207)
                {
                    colorName = "Island Palm";
                    orderCreated = true;
                    red = 90;
                    green = 137;
                    blue = 103;
                }
            else if (count == 208)
                {
                    colorName = "Antique Earth";
                    orderCreated = true;
                    red = 126;
                    green = 108;
                    blue = 96;
                }
            else if (count == 209)
                {
                    colorName = "Glowing Scarlet";
                    orderCreated = true;
                    red = 189;
                    green = 68;
                    blue = 74;
                }
            else if (count == 210)
                {
                    colorName = "Blue Luxury";
                    orderCreated = true;
                    red = 26;
                    green = 133;
                    blue = 172;
                }
            else if (count == 211)
                {
                    colorName = "Frog";
                    orderCreated = true;
                    red = 120;
                    green = 172;
                    blue = 40;
                }
            else if (count == 212)
                {
                    colorName = "Jack O Lantern";
                    orderCreated = true;
                    red = 194;
                    green = 90;
                    blue = 49;
                }
            else if (count == 213)
                {
                    colorName = "Mountain Elk";
                    orderCreated = true;
                    red = 121;
                    green = 123;
                    blue = 90;
                }
            else if (count == 214)
                {
                    colorName = "Tibetan Orange";
                    orderCreated = true;
                    red = 174;
                    green = 88;
                    blue = 73;
                }
            else if (count == 215)
                {
                    colorName = "Treasures";
                    orderCreated = true;
                    red = 184;
                    green = 137;
                    blue = 15;
                }
            else if (count == 216)
                {
                    colorName = "Sultry Smoke";
                    orderCreated = true;
                    red = 115;
                    green = 106;
                    blue = 116;
                }
            else if (count == 217)
                {
                    colorName = "Dragon Fire";
                    orderCreated = true;
                    red = 251;
                    green = 71;
                    blue = 15;
                }
            else if (count == 218)
                {
                    colorName = "Fern Grove";
                    orderCreated = true;
                    red = 131;
                    green = 123;
                    blue = 84;
                }
            else if (count == 219)
                {
                    colorName = "Mocha Latte";
                    orderCreated = true;
                    red = 130;
                    green = 112;
                    blue = 96;
                }
            else if (count == 220)
                {
                    colorName = "Conifer Green";
                    orderCreated = true;
                    red = 116;
                    green = 119;
                    blue = 104;
                }
            else if (count == 221)
                {
                    colorName = "Mixed Veggies";
                    orderCreated = true;
                    red = 97;
                    green = 172;
                    blue = 71;
                }
            else if (count == 222)
                {
                    colorName = "Arrowhead Lake";
                    orderCreated = true;
                    red = 87;
                    green = 114;
                    blue = 139;
                }
            else if (count == 223)
                {
                    colorName = "Tucson Teal";
                    orderCreated = true;
                    red = 35;
                    green = 167;
                    blue = 139;
                }
            else if (count == 224)
                {
                    colorName = "Hampton Surf";
                    orderCreated = true;
                    red = 89;
                    green = 119;
                    blue = 133;
                }
            else if (count == 225)
                {
                    colorName = "Venetian Gold";
                    orderCreated = true;
                    red = 169;
                    green = 146;
                    blue = 27;
                }
            else if (count == 226)
                {
                    colorName = "Fuschia Flair";
                    orderCreated = true;
                    red = 164;
                    green = 72;
                    blue = 107;
                }
            else if (count == 227)
                {
                    colorName = "Brandy";
                    orderCreated = true;
                    red = 150;
                    green = 91;
                    blue = 103;
                }
            else if (count == 228)
                {
                    colorName = "Venom";
                    orderCreated = true;
                    red = 157;
                    green = 187;
                    blue = 0;
                }
            else if (count == 229)
                {
                    colorName = "Gentle Doe";
                    orderCreated = true;
                    red = 145;
                    green = 94;
                    blue = 106;
                }
            else if (count == 230)
                {
                    colorName = "Sailors Bay";
                    orderCreated = true;
                    red = 55;
                    green = 117;
                    blue = 173;
                }
            else if (count == 231)
                {
                    colorName = "Fudge Bar";
                    orderCreated = true;
                    red = 142;
                    green = 113;
                    blue = 91;
                }
            else if (count == 232)
                {
                    colorName = "Mayan Treasure";
                    orderCreated = true;
                    red = 28;
                    green = 135;
                    blue = 183;
                }
            else if (count == 233)
                {
                    colorName = "Rooftop Garden";
                    orderCreated = true;
                    red = 124;
                    green = 117;
                    blue = 106;
                }
            else if (count == 234)
                {
                    colorName = "Hibiscus Flower";
                    orderCreated = true;
                    red = 189;
                    green = 49;
                    blue = 110;
                }
            else if (count == 235)
                {
                    colorName = "Emerald Coast";
                    orderCreated = true;
                    red = 41;
                    green = 190;
                    blue = 118;
                }
            else if (count == 236)
                {
                    colorName = "Dynamic Magenta";
                    orderCreated = true;
                    red = 137;
                    green = 84;
                    blue = 129;
                }
            else if (count == 237)
                {
                    colorName = "Wizard";
                    orderCreated = true;
                    red = 63;
                    green = 82;
                    blue = 205;
                }
            else if (count == 238)
                {
                    colorName = "Privileged Elite";
                    orderCreated = true;
                    red = 86;
                    green = 116;
                    blue = 149;
                }
            else if (count == 239)
                {
                    colorName = "Toasted Nutmeg";
                    orderCreated = true;
                    red = 154;
                    green = 100;
                    blue = 98;
                }
            else if (count == 240)
                {
                    colorName = "Bitter Briar";
                    orderCreated = true;
                    red = 128;
                    green = 108;
                    blue = 116;
                }
            else if (count == 241)
                {
                    colorName = "Echo";
                    orderCreated = true;
                    red = 121;
                    green = 114;
                    blue = 117;
                }
            else if (count == 242)
                {
                    colorName = "Heather Sachet";
                    orderCreated = true;
                    red = 123;
                    green = 113;
                    blue = 117;
                }
            else if (count == 243)
                {
                    colorName = "Atlantic Blue";
                    orderCreated = true;
                    red = 77;
                    green = 112;
                    blue = 165;
                }
            else if (count == 244)
                {
                    colorName = "Lucky Bamboo";
                    orderCreated = true;
                    red = 147;
                    green = 131;
                    blue = 76;
                }
            else if (count == 245)
                {
                    colorName = "Grape Leaves";
                    orderCreated = true;
                    red = 137;
                    green = 168;
                    blue = 51;
                }
            else if (count == 246)
                {
                    colorName = "New Age Blue";
                    orderCreated = true;
                    red = 72;
                    green = 110;
                    blue = 174;
                }
            else if (count == 247)
                {
                    colorName = "Coney Island";
                    orderCreated = true;
                    red = 91;
                    green = 138;
                    blue = 128;
                }
            else if (count == 248)
                {
                    colorName = "Yogi";
                    orderCreated = true;
                    red = 124;
                    green = 153;
                    blue = 80;
                }
            else if (count == 249)
                {
                    colorName = "Blue Aura";
                    orderCreated = true;
                    red = 108;
                    green = 115;
                    blue = 135;
                }
            else if (count == 250)
                {
                    colorName = "Lemon Grass";
                    orderCreated = true;
                    red = 157;
                    green = 183;
                    blue = 19;
                }
            else if (count == 251)
                {
                    colorName = "Cran Brook";
                    orderCreated = true;
                    red = 161;
                    green = 50;
                    blue = 149;
                }
            else if (count == 252)
                {
                    colorName = "Plum Shadow";
                    orderCreated = true;
                    red = 124;
                    green = 112;
                    blue = 124;
                }
            else if (count == 253)
                {
                    colorName = "Roasted Cashew";
                    orderCreated = true;
                    red = 176;
                    green = 122;
                    blue = 63;
                }
            else if (count == 254)
                {
                    colorName = "Green Neon";
                    orderCreated = true;
                    red = 168;
                    green = 194;
                    blue = 0;
                }
            else if (count == 255)
                {
                    colorName = "Chocolate Delight";
                    orderCreated = true;
                    red = 140;
                    green = 112;
                    blue = 111;
                }
            else if (count == 256)
                {
                    colorName = "Hidden Peak";
                    orderCreated = true;
                    red = 98;
                    green = 134;
                    blue = 132;
                }
            else if (count == 257)
                {
                    colorName = "Milk Chocolate";
                    orderCreated = true;
                    red = 137;
                    green = 111;
                    blue = 117;
                }
            else if (count == 258)
                {
                    colorName = "Coconut Shell";
                    orderCreated = true;
                    red = 141;
                    green = 121;
                    blue = 103;
                }
            else if (count == 259)
                {
                    colorName = "Marsh Creek";
                    orderCreated = true;
                    red = 91;
                    green = 150;
                    blue = 125;
                }
            else if (count == 260)
                {
                    colorName = "Violet Vixen";
                    orderCreated = true;
                    red = 116;
                    green = 106;
                    blue = 144;
                }
            else if (count == 261)
                {
                    colorName = "Summer Citrus";
                    orderCreated = true;
                    red = 255;
                    green = 101;
                    blue = 10;
                }
            else if (count == 262)
                {
                    colorName = "Wizards Potion";
                    orderCreated = true;
                    red = 65;
                    green = 80;
                    blue = 222;
                }
            else if (count == 263)
                {
                    colorName = "Rose Marquee";
                    orderCreated = true;
                    red = 167;
                    green = 100;
                    blue = 101;
                }
            else if (count == 264)
                {
                    colorName = "Forest Berry";
                    orderCreated = true;
                    red = 149;
                    green = 98;
                    blue = 121;
                }
            else if (count == 265)
                {
                    colorName = "Yam";
                    orderCreated = true;
                    red = 242;
                    green = 128;
                    blue = 0;
                }
            else if (count == 266)
                {
                    colorName = "Manuscript";
                    orderCreated = true;
                    red = 130;
                    green = 126;
                    blue = 114;
                }
            else if (count == 267)
                {
                    colorName = "Bitter Lemon";
                    orderCreated = true;
                    red = 161;
                    green = 153;
                    blue = 57;
                }
            else if (count == 268)
                {
                    colorName = "Stormy Gray";
                    orderCreated = true;
                    red = 110;
                    green = 129;
                    blue = 133;
                }
            else if (count == 269)
                {
                    colorName = "Splendor And Pride";
                    orderCreated = true;
                    red = 89;
                    green = 114;
                    blue = 169;
                }
            else if (count == 270)
                {
                    colorName = "Shire Green";
                    orderCreated = true;
                    red = 101;
                    green = 195;
                    blue = 77;
                }
            else if (count == 271)
                {
                    colorName = "Amazon Moss";
                    orderCreated = true;
                    red = 111;
                    green = 153;
                    blue = 111;
                }
            else if (count == 272)
                {
                    colorName = "Berries And Cream";
                    orderCreated = true;
                    red = 150;
                    green = 84;
                    blue = 142;
                }
            else if (count == 273)
                {
                    colorName = "Mulling Spice";
                    orderCreated = true;
                    red = 193;
                    green = 123;
                    blue = 61;
                }
            else if (count == 274)
                {
                    colorName = "Ivy Wreath";
                    orderCreated = true;
                    red = 112;
                    green = 142;
                    blue = 123;
                }
            else if (count == 275)
                {
                    colorName = "Shallot Bulb";
                    orderCreated = true;
                    red = 122;
                    green = 141;
                    blue = 115;
                }
            else if (count == 276)
                {
                    colorName = "Scene Stealer";
                    orderCreated = true;
                    red = 171;
                    green = 108;
                    blue = 100;
                }
            else if (count == 277)
                {
                    colorName = "Atlantic Shoreline";
                    orderCreated = true;
                    red = 112;
                    green = 129;
                    blue = 138;
                }
            else if (count == 278)
                {
                    colorName = "Mississippi Mud";
                    orderCreated = true;
                    red = 141;
                    green = 138;
                    blue = 101;
                }
            else if (count == 279)
                {
                    colorName = "Marmalade Glaze";
                    orderCreated = true;
                    red = 194;
                    green = 117;
                    blue = 69;
                }
            else if (count == 280)
                {
                    colorName = "Purple Paradise";
                    orderCreated = true;
                    red = 121;
                    green = 102;
                    blue = 158;
                }
            else if (count == 281)
                {
                    colorName = "Sienna";
                    orderCreated = true;
                    red = 166;
                    green = 116;
                    blue = 100;
                }
            else if (count == 282)
                {
                    colorName = "Boston Fern";
                    orderCreated = true;
                    red = 131;
                    green = 167;
                    blue = 85;
                }
            else if (count == 283)
                {
                    colorName = "Autumn Russet";
                    orderCreated = true;
                    red = 161;
                    green = 113;
                    blue = 109;
                }
            else if (count == 284)
                {
                    colorName = "Dash Of Curry";
                    orderCreated = true;
                    red = 207;
                    green = 81;
                    blue = 96;
                }
            else if (count == 285)
                {
                    colorName = "Sofisticata";
                    orderCreated = true;
                    red = 148;
                    green = 128;
                    blue = 108;
                }
            else if (count == 286)
                {
                    colorName = "Frontier Brown";
                    orderCreated = true;
                    red = 144;
                    green = 129;
                    blue = 112;
                }
            else if (count == 287)
                {
                    colorName = "Bella Vista";
                    orderCreated = true;
                    red = 42;
                    green = 184;
                    blue = 160;
                }
            else if (count == 288)
                {
                    colorName = "Mocha Accent";
                    orderCreated = true;
                    red = 142;
                    green = 130;
                    blue = 115;
                }
            else if (count == 289)
                {
                    colorName = "Brazilian Citrine";
                    orderCreated = true;
                    red = 169;
                    green = 147;
                    blue = 71;
                }
            else if (count == 290)
                {
                    colorName = "Drama Queen";
                    orderCreated = true;
                    red = 184;
                    green = 102;
                    blue = 102;
                }
            else if (count == 291)
                {
                    colorName = "Diva Glam";
                    orderCreated = true;
                    red = 176;
                    green = 42;
                    blue = 170;
                }
            else if (count == 292)
                {
                    colorName = "Thermal Spring";
                    orderCreated = true;
                    red = 78;
                    green = 183;
                    blue = 128;
                }
            else if (count == 293)
                {
                    colorName = "Hunt Club Brown";
                    orderCreated = true;
                    red = 147;
                    green = 130;
                    blue = 113;
                }
            else if (count == 294)
                {
                    colorName = "Collectible";
                    orderCreated = true;
                    red = 155;
                    green = 131;
                    blue = 104;
                }
            else if (count == 295)
                {
                    colorName = "Ottertail";
                    orderCreated = true;
                    red = 136;
                    green = 136;
                    blue = 119;
                }
            else if (count == 296)
                {
                    colorName = "Rice Curry";
                    orderCreated = true;
                    red = 179;
                    green = 135;
                    blue = 78;
                }
            else if (count == 297)
                {
                    colorName = "Atomic Tangerine";
                    orderCreated = true;
                    red = 255;
                    green = 137;
                    blue = 0;
                }
            else if (count == 298)
                {
                    colorName = "Woodcraft";
                    orderCreated = true;
                    red = 132;
                    green = 136;
                    blue = 125;
                }
            else if (count == 299)
                {
                    colorName = "Tasmanian Sea";
                    orderCreated = true;
                    red = 88;
                    green = 160;
                    blue = 145;
                }
            else if (count == 300)
                {
                    colorName = "Pier";
                    orderCreated = true;
                    red = 135;
                    green = 133;
                    blue = 126;
                }
            else if (count == 301)
                {
                    colorName = "Blanket Brown";
                    orderCreated = true;
                    red = 149;
                    green = 131;
                    blue = 115;
                }
            else if (count == 302)
                {
                    colorName = "Wet Coral";
                    orderCreated = true;
                    red = 244;
                    green = 74;
                    blue = 78;
                }
            else if (count == 303)
                {
                    colorName = "Moroccan Sky";
                    orderCreated = true;
                    red = 191;
                    green = 119;
                    blue = 86;
                }
            else if (count == 304)
                {
                    colorName = "Pandora";
                    orderCreated = true;
                    red = 90;
                    green = 89;
                    blue = 218;
                }
            else if (count == 305)
                {
                    colorName = "Forever Denim";
                    orderCreated = true;
                    red = 119;
                    green = 133;
                    blue = 145;
                }
            else if (count == 306)
                {
                    colorName = "Semi-precious";
                    orderCreated = true;
                    red = 96;
                    green = 152;
                    blue = 150;
                }
            else if (count == 307)
                {
                    colorName = "Dry Pasture";
                    orderCreated = true;
                    red = 148;
                    green = 137;
                    blue = 114;
                }
            else if (count == 308)
                {
                    colorName = "Wet Cement";
                    orderCreated = true;
                    red = 137;
                    green = 135;
                    blue = 128;
                }
            else if (count == 309)
                {
                    colorName = "Dragonfly";
                    orderCreated = true;
                    red = 114;
                    green = 144;
                    blue = 142;
                }
            else if (count == 310)
                {
                    colorName = "Warm Cognac";
                    orderCreated = true;
                    red = 164;
                    green = 129;
                    blue = 108;
                }
            else if (count == 311)
                {
                    colorName = "Purple Potion";
                    orderCreated = true;
                    red = 117;
                    green = 112;
                    blue = 172;
                }
            else if (count == 312)
                {
                    colorName = "Squirrel";
                    orderCreated = true;
                    red = 133;
                    green = 146;
                    blue = 123;
                }
            else if (count == 313)
                {
                    colorName = "Matadors Cape";
                    orderCreated = true;
                    red = 211;
                    green = 79;
                    blue = 113;
                }
            else if (count == 314)
                {
                    colorName = "Gypsy Magic";
                    orderCreated = true;
                    red = 135;
                    green = 120;
                    blue = 149;
                }
            else if (count == 315)
                {
                    colorName = "Exotic Palm";
                    orderCreated = true;
                    red = 145;
                    green = 152;
                    blue = 107;
                }
            else if (count == 316)
                {
                    colorName = "Ethiopia";
                    orderCreated = true;
                    red = 150;
                    green = 135;
                    blue = 119;
                }
            else if (count == 317)
                {
                    colorName = "Old Amethyst";
                    orderCreated = true;
                    red = 132;
                    green = 131;
                    blue = 142;
                }
            else if (count == 318)
                {
                    colorName = "Milestone";
                    orderCreated = true;
                    red = 114;
                    green = 140;
                    blue = 152;
                }
            else if (count == 319)
                {
                    colorName = "Zesty Apple";
                    orderCreated = true;
                    red = 147;
                    green = 163;
                    blue = 97;
                }
            else if (count == 320)
                {
                    colorName = "Laser";
                    orderCreated = true;
                    red = 172;
                    green = 198;
                    blue = 37;
                }
            else if (count == 321)
                {
                    colorName = "Joyful Orange";
                    orderCreated = true;
                    red = 255;
                    green = 124;
                    blue = 30;
                }
            else if (count == 322)
                {
                    colorName = "Butter Rum";
                    orderCreated = true;
                    red = 195;
                    green = 133;
                    blue = 81;
                }
            else if (count == 323)
                {
                    colorName = "Majestic Mount";
                    orderCreated = true;
                    red = 108;
                    green = 132;
                    blue = 170;
                }
            else if (count == 324)
                {
                    colorName = "Mars Red";
                    orderCreated = true;
                    red = 174;
                    green = 125;
                    blue = 111;
                }
            else if (count == 325)
                {
                    colorName = "Riviera Paradise";
                    orderCreated = true;
                    red = 42;
                    green = 173;
                    blue = 196;
                }
            else if (count == 326)
                {
                    colorName = "Concrete Sidewalk";
                    orderCreated = true;
                    red = 131;
                    green = 148;
                    blue = 133;
                }
            else if (count == 327)
                {
                    colorName = "Thistle";
                    orderCreated = true;
                    red = 135;
                    green = 146;
                    blue = 131;
                }
            else if (count == 328)
                {
                    colorName = "November";
                    orderCreated = true;
                    red = 190;
                    green = 118;
                    blue = 105;
                }
            else if (count == 329)
                {
                    colorName = "Bali Bliss";
                    orderCreated = true;
                    red = 94;
                    green = 158;
                    blue = 161;
                }
            else if (count == 330)
                {
                    colorName = "Burnt Pumpkin";
                    orderCreated = true;
                    red = 202;
                    green = 143;
                    blue = 69;
                }
            else if (count == 331)
                {
                    colorName = "Palace Purple";
                    orderCreated = true;
                    red = 98;
                    green = 117;
                    blue = 200;
                }
            else if (count == 332)
                {
                    colorName = "Alamosa Green";
                    orderCreated = true;
                    red = 147;
                    green = 154;
                    blue = 114;
                }
            else if (count == 333)
                {
                    colorName = "Hickory Branch";
                    orderCreated = true;
                    red = 166;
                    green = 130;
                    blue = 120;
                }
            else if (count == 334)
                {
                    colorName = "Mandarin";
                    orderCreated = true;
                    red = 241;
                    green = 112;
                    blue = 63;
                }
            else if (count == 335)
                {
                    colorName = "Deep Smoke Signal";
                    orderCreated = true;
                    red = 111;
                    green = 137;
                    blue = 169;
                }
            else if (count == 336)
                {
                    colorName = "Smoke Bush Rose";
                    orderCreated = true;
                    red = 168;
                    green = 120;
                    blue = 129;
                }
            else if (count == 337)
                {
                    colorName = "Bedford Brown";
                    orderCreated = true;
                    red = 163;
                    green = 118;
                    blue = 138;
                }
            else if (count == 338)
                {
                    colorName = "Polished Stone";
                    orderCreated = true;
                    red = 146;
                    green = 137;
                    blue = 136;
                }
            else if (count == 339)
                {
                    colorName = "Poppy Glow";
                    orderCreated = true;
                    red = 250;
                    green = 118;
                    blue = 52;
                }
            else if (count == 340)
                {
                    colorName = "Fashion Week";
                    orderCreated = true;
                    red = 149;
                    green = 135;
                    blue = 136;
                }
            else if (count == 341)
                {
                    colorName = "Desert Shadows";
                    orderCreated = true;
                    red = 150;
                    green = 155;
                    blue = 116;
                }
            else if (count == 342)
                {
                    colorName = "Mulberry";
                    orderCreated = true;
                    red = 192;
                    green = 69;
                    blue = 161;
                }
            else if (count == 343)
                {
                    colorName = "Applause Please";
                    orderCreated = true;
                    red = 131;
                    green = 137;
                    blue = 154;
                }
            else if (count == 344)
                {
                    colorName = "Gothic Amethyst";
                    orderCreated = true;
                    red = 128;
                    green = 133;
                    blue = 162;
                }
            else if (count == 345)
                {
                    colorName = "Eco Green";
                    orderCreated = true;
                    red = 168;
                    green = 150;
                    blue = 105;
                }
            else if (count == 346)
                {
                    colorName = "Solid Gold";
                    orderCreated = true;
                    red = 200;
                    green = 152;
                    blue = 72;
                }
            else if (count == 347)
                {
                    colorName = "Flaming Torch";
                    orderCreated = true;
                    red = 211;
                    green = 134;
                    blue = 79;
                }
            else if (count == 348)
                {
                    colorName = "Antique Leather";
                    orderCreated = true;
                    red = 158;
                    green = 141;
                    blue = 126;
                }
            else if (count == 349)
                {
                    colorName = "Miracle Elixir";
                    orderCreated = true;
                    red = 80;
                    green = 128;
                    blue = 218;
                }
            else if (count == 350)
                {
                    colorName = "Plum Swirl";
                    orderCreated = true;
                    red = 137;
                    green = 121;
                    blue = 169;
                }
            else if (count == 351)
                {
                    colorName = "Milkweed Pod";
                    orderCreated = true;
                    red = 139;
                    green = 170;
                    blue = 118;
                }
            else if (count == 352)
                {
                    colorName = "Muse";
                    orderCreated = true;
                    red = 161;
                    green = 127;
                    blue = 141;
                }
            else if (count == 353)
                {
                    colorName = "Carmelite";
                    orderCreated = true;
                    red = 183;
                    green = 135;
                    blue = 111;
                }
            else if (count == 354)
                {
                    colorName = "Blue Chaise";
                    orderCreated = true;
                    red = 67;
                    green = 165;
                    blue = 198;
                }
            else if (count == 355)
                {
                    colorName = "Lovebirds";
                    orderCreated = true;
                    red = 202;
                    green = 74;
                    blue = 154;
                }
            else if (count == 356)
                {
                    colorName = "Cliff Rock";
                    orderCreated = true;
                    red = 171;
                    green = 151;
                    blue = 109;
                }
            else if (count == 357)
                {
                    colorName = "Thundercloud";
                    orderCreated = true;
                    red = 98;
                    green = 149;
                    blue = 185;
                }
            else if (count == 358)
                {
                    colorName = "Voyage";
                    orderCreated = true;
                    red = 112;
                    green = 156;
                    blue = 165;
                }
            else if (count == 359)
                {
                    colorName = "Contessa";
                    orderCreated = true;
                    red = 150;
                    green = 139;
                    blue = 145;
                }
            else if (count == 360)
                {
                    colorName = "Bermuda Grass";
                    orderCreated = true;
                    red = 158;
                    green = 156;
                    blue = 121;
                }
            else if (count == 361)
                {
                    colorName = "Mesa Sunrise";
                    orderCreated = true;
                    red = 245;
                    green = 99;
                    blue = 93;
                }
            else if (count == 362)
                {
                    colorName = "Keystone";
                    orderCreated = true;
                    red = 178;
                    green = 145;
                    blue = 114;
                }
            else if (count == 363)
                {
                    colorName = "Chick Flick";
                    orderCreated = true;
                    red = 188;
                    green = 123;
                    blue = 127;
                }
            else if (count == 364)
                {
                    colorName = "Burnished Caramel";
                    orderCreated = true;
                    red = 190;
                    green = 145;
                    blue = 104;
                }
            else if (count == 365)
                {
                    colorName = "Coastal Vista";
                    orderCreated = true;
                    red = 130;
                    green = 147;
                    blue = 162;
                }
            else if (count == 366)
                {
                    colorName = "Fresh Olive";
                    orderCreated = true;
                    red = 166;
                    green = 157;
                    blue = 116;
                }
            else if (count == 367)
                {
                    colorName = "Gourmet Mushroom";
                    orderCreated = true;
                    red = 141;
                    green = 147;
                    blue = 152;
                }
            else if (count == 368)
                {
                    colorName = "Cameo Rose";
                    orderCreated = true;
                    red = 163;
                    green = 139;
                    blue = 138;
                }
            else if (count == 369)
                {
                    colorName = "Milk Thistle";
                    orderCreated = true;
                    red = 155;
                    green = 152;
                    blue = 134;
                }
            else if (count == 370)
                {
                    colorName = "Antique Treasure";
                    orderCreated = true;
                    red = 183;
                    green = 155;
                    blue = 104;
                }
            else if (count == 371)
                {
                    colorName = "Golden Cricket";
                    orderCreated = true;
                    red = 212;
                    green = 178;
                    blue = 53;
                }
            else if (count == 372)
                {
                    colorName = "Free Green";
                    orderCreated = true;
                    red = 107;
                    green = 205;
                    blue = 131;
                }
            else if (count == 373)
                {
                    colorName = "Dusty Olive";
                    orderCreated = true;
                    red = 157;
                    green = 151;
                    blue = 135;
                }
            else if (count == 374)
                {
                    colorName = "Tribeca";
                    orderCreated = true;
                    red = 161;
                    green = 143;
                    blue = 140;
                }
            else if (count == 375)
                {
                    colorName = "Pure Earth";
                    orderCreated = true;
                    red = 167;
                    green = 148;
                    blue = 129;
                }
            else if (count == 376)
                {
                    colorName = "Golden Sage";
                    orderCreated = true;
                    red = 173;
                    green = 156;
                    blue = 116;
                }
            else if (count == 377)
                {
                    colorName = "Rainy Season";
                    orderCreated = true;
                    red = 131;
                    green = 153;
                    blue = 162;
                }
            else if (count == 378)
                {
                    colorName = "Exploring Khaki";
                    orderCreated = true;
                    red = 170;
                    green = 154;
                    blue = 122;
                }
            else if (count == 379)
                {
                    colorName = "Anime";
                    orderCreated = true;
                    red = 197;
                    green = 213;
                    blue = 37;
                }
            else if (count == 380)
                {
                    colorName = "Cozumel";
                    orderCreated = true;
                    red = 59;
                    green = 240;
                    blue = 149;
                }
            else if (count == 381)
                {
                    colorName = "Sustainable";
                    orderCreated = true;
                    red = 159;
                    green = 174;
                    blue = 115;
                }
            else if (count == 382)
                {
                    colorName = "Artisan Crafts";
                    orderCreated = true;
                    red = 181;
                    green = 152;
                    blue = 116;
                }
            else if (count == 383)
                {
                    colorName = "Romanesque";
                    orderCreated = true;
                    red = 108;
                    green = 135;
                    blue = 207;
                }
            else if (count == 384)
                {
                    colorName = "Schooner";
                    orderCreated = true;
                    red = 127;
                    green = 161;
                    blue = 162;
                }
            else if (count == 385)
                {
                    colorName = "Rosily";
                    orderCreated = true;
                    red = 192;
                    green = 93;
                    blue = 166;
                }
            else if (count == 386)
                {
                    colorName = "Mocha Tan";
                    orderCreated = true;
                    red = 172;
                    green = 149;
                    blue = 130;
                }
            else if (count == 387)
                {
                    colorName = "Nectarina";
                    orderCreated = true;
                    red = 213;
                    green = 125;
                    blue = 114;
                }
            else if (count == 388)
                {
                    colorName = "Chinese Violet";
                    orderCreated = true;
                    red = 120;
                    green = 127;
                    blue = 206;
                }
            else if (count == 389)
                {
                    colorName = "Caramel Cream";
                    orderCreated = true;
                    red = 181;
                    green = 145;
                    blue = 127;
                }
            else if (count == 390)
                {
                    colorName = "Cloud Burst";
                    orderCreated = true;
                    red = 126;
                    green = 174;
                    blue = 154;
                }
            else if (count == 391)
                {
                    colorName = "Studio Taupe";
                    orderCreated = true;
                    red = 165;
                    green = 151;
                    blue = 138;
                }
            else if (count == 392)
                {
                    colorName = "Yellow Flash";
                    orderCreated = true;
                    red = 255;
                    green = 200;
                    blue = 0;
                }
            else if (count == 393)
                {
                    colorName = "Peach Butter";
                    orderCreated = true;
                    red = 255;
                    green = 162;
                    blue = 38;
                }
            else if (count == 394)
                {
                    colorName = "Warm Spring";
                    orderCreated = true;
                    red = 60;
                    green = 154;
                    blue = 242;
                }
            else if (count == 395)
                {
                    colorName = "Cricket";
                    orderCreated = true;
                    red = 166;
                    green = 160;
                    blue = 130;
                }
            else if (count == 396)
                {
                    colorName = "Aspen Aura";
                    orderCreated = true;
                    red = 122;
                    green = 193;
                    blue = 142;
                }
            else if (count == 397)
                {
                    colorName = "Natchez Moss";
                    orderCreated = true;
                    red = 177;
                    green = 167;
                    blue = 113;
                }
            else if (count == 398)
                {
                    colorName = "Chilled Wine";
                    orderCreated = true;
                    red = 188;
                    green = 183;
                    blue = 88;
                }
            else if (count == 399)
                {
                    colorName = "Moonquake";
                    orderCreated = true;
                    red = 133;
                    green = 163;
                    blue = 163;
                }
            else if (count == 400)
                {
                    colorName = "Soft Boiled";
                    orderCreated = true;
                    red = 255;
                    green = 175;
                    blue = 30;
                }
            else if (count == 401)
                {
                    colorName = "Foxen";
                    orderCreated = true;
                    red = 190;
                    green = 134;
                    blue = 137;
                }
            else if (count == 402)
                {
                    colorName = "Key To The City";
                    orderCreated = true;
                    red = 185;
                    green = 152;
                    blue = 124;
                }
            else if (count == 403)
                {
                    colorName = "Pesto Green";
                    orderCreated = true;
                    red = 152;
                    green = 169;
                    blue = 140;
                }
            else if (count == 404)
                {
                    colorName = "Marigold";
                    orderCreated = true;
                    red = 254;
                    green = 208;
                    blue = 0;
                }
            else if (count == 405)
                {
                    colorName = "Shiitake";
                    orderCreated = true;
                    red = 159;
                    green = 159;
                    blue = 144;
                }
            else if (count == 406)
                {
                    colorName = "Alpha Blue";
                    orderCreated = true;
                    red = 79;
                    green = 162;
                    blue = 222;
                }
            else if (count == 407)
                {
                    colorName = "Warm Stone";
                    orderCreated = true;
                    red = 161;
                    green = 161;
                    blue = 142;
                }
            else if (count == 408)
                {
                    colorName = "Cosmic Coral";
                    orderCreated = true;
                    red = 230;
                    green = 125;
                    blue = 110;
                }
            else if (count == 409)
                {
                    colorName = "Summer In The City";
                    orderCreated = true;
                    red = 203;
                    green = 159;
                    blue = 104;
                }
            else if (count == 410)
                {
                    colorName = "Turquoise";
                    orderCreated = true;
                    red = 90;
                    green = 196;
                    blue = 181;
                }
            else if (count == 411)
                {
                    colorName = "Teatime";
                    orderCreated = true;
                    red = 190;
                    green = 155;
                    blue = 122;
                }
            else if (count == 412)
                {
                    colorName = "Pencil Sketch";
                    orderCreated = true;
                    red = 153;
                    green = 157;
                    blue = 158;
                }
            else if (count == 413)
                {
                    colorName = "Country Weekend";
                    orderCreated = true;
                    red = 131;
                    green = 189;
                    blue = 149;
                }
            else if (count == 414)
                {
                    colorName = "Amber Brew";
                    orderCreated = true;
                    red = 214;
                    green = 160;
                    blue = 96;
                }
            else if (count == 415)
                {
                    colorName = "Ponder";
                    orderCreated = true;
                    red = 183;
                    green = 137;
                    blue = 151;
                }
            else if (count == 416)
                {
                    colorName = "Desert Willow";
                    orderCreated = true;
                    red = 173;
                    green = 148;
                    blue = 151;
                }
            else if (count == 417)
                {
                    colorName = "Veiled Chameleon";
                    orderCreated = true;
                    red = 121;
                    green = 227;
                    blue = 124;
                }
            else if (count == 418)
                {
                    colorName = "Lazy Caterpillar";
                    orderCreated = true;
                    red = 159;
                    green = 221;
                    blue = 92;
                }
            else if (count == 419)
                {
                    colorName = "Corsican Purple";
                    orderCreated = true;
                    red = 110;
                    green = 138;
                    blue = 225;
                }
            else if (count == 420)
                {
                    colorName = "Sulfur Yellow";
                    orderCreated = true;
                    red = 215;
                    green = 202;
                    blue = 56;
                }
            else if (count == 421)
                {
                    colorName = "Evening In Paris";
                    orderCreated = true;
                    red = 138;
                    green = 149;
                    blue = 187;
                }
            else if (count == 422)
                {
                    colorName = "Boat House";
                    orderCreated = true;
                    red = 72;
                    green = 158;
                    blue = 245;
                }
            else if (count == 423)
                {
                    colorName = "Orange Spice";
                    orderCreated = true;
                    red = 255;
                    green = 141;
                    blue = 80;
                }
            else if (count == 424)
                {
                    colorName = "Splendor Gold";
                    orderCreated = true;
                    red = 255;
                    green = 165;
                    blue = 56;
                }
            else if (count == 425)
                {
                    colorName = "Chamois Tan";
                    orderCreated = true;
                    red = 180;
                    green = 162;
                    blue = 134;
                }
            else if (count == 426)
                {
                    colorName = "Craft Brown";
                    orderCreated = true;
                    red = 184;
                    green = 160;
                    blue = 133;
                }
            else if (count == 427)
                {
                    colorName = "Peanut Butter";
                    orderCreated = true;
                    red = 199;
                    green = 161;
                    blue = 118;
                }
            else if (count == 428)
                {
                    colorName = "Amazonian Orchid";
                    orderCreated = true;
                    red = 159;
                    green = 118;
                    blue = 201;
                }
            else if (count == 429)
                {
                    colorName = "Lily Of The Nile";
                    orderCreated = true;
                    red = 145;
                    green = 145;
                    blue = 188;
                }
            else if (count == 430)
                {
                    colorName = "Berry Blush";
                    orderCreated = true;
                    red = 181;
                    green = 119;
                    blue = 179;
                }
            else if (count == 431)
                {
                    colorName = "Pressed Blossoms";
                    orderCreated = true;
                    red = 192;
                    green = 148;
                    blue = 140;
                }
            else if (count == 432)
                {
                    colorName = "Abbey Stone";
                    orderCreated = true;
                    red = 171;
                    green = 160;
                    blue = 150;
                }
            else if (count == 433)
                {
                    colorName = "Chestnut Bisque";
                    orderCreated = true;
                    red = 190;
                    green = 154;
                    blue = 137;
                }
            else if (count == 434)
                {
                    colorName = "Pink Damask";
                    orderCreated = true;
                    red = 221;
                    green = 109;
                    blue = 152;
                }
            else if (count == 435)
                {
                    colorName = "Florida Mango";
                    orderCreated = true;
                    red = 246;
                    green = 141;
                    blue = 97;
                }
            else if (count == 436)
                {
                    colorName = "Coffee With Cream";
                    orderCreated = true;
                    red = 170;
                    green = 159;
                    blue = 155;
                }
            else if (count == 437)
                {
                    colorName = "Cabaret";
                    orderCreated = true;
                    red = 181;
                    green = 110;
                    blue = 194;
                }
            else if (count == 438)
                {
                    colorName = "Tarragon Tease";
                    orderCreated = true;
                    red = 180;
                    green = 172;
                    blue = 133;
                }
            else if (count == 439)
                {
                    colorName = "Oceanus";
                    orderCreated = true;
                    red = 144;
                    green = 172;
                    blue = 170;
                }
            else if (count == 440)
                {
                    colorName = "Simply Sage";
                    orderCreated = true;
                    red = 167;
                    green = 168;
                    blue = 151;
                }
            else if (count == 441)
                {
                    colorName = "Amethyst Phlox";
                    orderCreated = true;
                    red = 147;
                    green = 150;
                    blue = 190;
                }
            else if (count == 442)
                {
                    colorName = "Safari Vest";
                    orderCreated = true;
                    red = 178;
                    green = 165;
                    blue = 144;
                }
            else if (count == 443)
                {
                    colorName = "Stone Walls";
                    orderCreated = true;
                    red = 175;
                    green = 167;
                    blue = 146;
                }
            else if (count == 444)
                {
                    colorName = "Watermelon Punch";
                    orderCreated = true;
                    red = 224;
                    green = 136;
                    blue = 129;
                }
            else if (count == 445)
                {
                    colorName = "Orchid Kiss";
                    orderCreated = true;
                    red = 165;
                    green = 92;
                    blue = 233;
                }
            else if (count == 446)
                {
                    colorName = "Moleskin";
                    orderCreated = true;
                    red = 177;
                    green = 161;
                    blue = 152;
                }
            else if (count == 447)
                {
                    colorName = "Green Meets Blue";
                    orderCreated = true;
                    red = 134;
                    green = 193;
                    blue = 163;
                }
            else if (count == 448)
                {
                    colorName = "Garden Wall";
                    orderCreated = true;
                    red = 169;
                    green = 174;
                    blue = 148;
                }
            else if (count == 449)
                {
                    colorName = "Yucatan";
                    orderCreated = true;
                    red = 59;
                    green = 206;
                    blue = 226;
                }
            else if (count == 450)
                {
                    colorName = "Brookview";
                    orderCreated = true;
                    red = 147;
                    green = 215;
                    blue = 130;
                }
            else if (count == 451)
                {
                    colorName = "Flax Straw";
                    orderCreated = true;
                    red = 202;
                    green = 174;
                    blue = 116;
                }
            else if (count == 452)
                {
                    colorName = "Albuquerque";
                    orderCreated = true;
                    red = 203;
                    green = 163;
                    blue = 127;
                }
            else if (count == 453)
                {
                    colorName = "Garden View";
                    orderCreated = true;
                    red = 131;
                    green = 223;
                    blue = 140;
                }
            else if (count == 454)
                {
                    colorName = "English Custard";
                    orderCreated = true;
                    red = 227;
                    green = 181;
                    blue = 87;
                }
            else if (count == 455)
                {
                    colorName = "Fond Memory";
                    orderCreated = true;
                    red = 178;
                    green = 152;
                    blue = 166;
                }
            else if (count == 456)
                {
                    colorName = "British Khaki";
                    orderCreated = true;
                    red = 187;
                    green = 167;
                    blue = 142;
                }
            else if (count == 457)
                {
                    colorName = "Bright Star";
                    orderCreated = true;
                    red = 255;
                    green = 207;
                    blue = 34;
                }
            else if (count == 458)
                {
                    colorName = "Safari Chic";
                    orderCreated = true;
                    red = 180;
                    green = 167;
                    blue = 150;
                }
            else if (count == 459)
                {
                    colorName = "Caramel Sundae";
                    orderCreated = true;
                    red = 228;
                    green = 159;
                    blue = 111;
                }
            else if (count == 460)
                {
                    colorName = "Integrity";
                    orderCreated = true;
                    red = 92;
                    green = 151;
                    blue = 255;
                }
            else if (count == 461)
                {
                    colorName = "Vintage Orange";
                    orderCreated = true;
                    red = 255;
                    green = 164;
                    blue = 80;
                }
            else if (count == 462)
                {
                    colorName = "Rugged Tan";
                    orderCreated = true;
                    red = 179;
                    green = 167;
                    blue = 153;
                }
            else if (count == 463)
                {
                    colorName = "Field Khaki";
                    orderCreated = true;
                    red = 172;
                    green = 180;
                    blue = 148;
                }
            else if (count == 464)
                {
                    colorName = "Golden Chalice";
                    orderCreated = true;
                    red = 230;
                    green = 196;
                    blue = 75;
                }
            else if (count == 465)
                {
                    colorName = "Paris";
                    orderCreated = true;
                    red = 145;
                    green = 167;
                    blue = 189;
                }
            else if (count == 466)
                {
                    colorName = "Watermelon Pink";
                    orderCreated = true;
                    red = 236;
                    green = 83;
                    blue = 183;
                }
            else if (count == 467)
                {
                    colorName = "Sweet Curry";
                    orderCreated = true;
                    red = 238;
                    green = 158;
                    blue = 106;
                }
            else if (count == 468)
                {
                    colorName = "Shoreline Green";
                    orderCreated = true;
                    red = 99;
                    green = 255;
                    blue = 149;
                }
            else if (count == 469)
                {
                    colorName = "Artifact";
                    orderCreated = true;
                    red = 200;
                    green = 153;
                    blue = 151;
                }
            else if (count == 470)
                {
                    colorName = "Good Luck";
                    orderCreated = true;
                    red = 130;
                    green = 255;
                    blue = 119;
                }
            else if (count == 471)
                {
                    colorName = "Great Falls";
                    orderCreated = true;
                    red = 159;
                    green = 166;
                    blue = 180;
                }
            else if (count == 472)
                {
                    colorName = "Kauai";
                    orderCreated = true;
                    red = 101;
                    green = 255;
                    blue = 150;
                }
            else if (count == 473)
                {
                    colorName = "Fuchsia Kiss";
                    orderCreated = true;
                    red = 207;
                    green = 77;
                    blue = 223;
                }
            else if (count == 474)
                {
                    colorName = "Gilded";
                    orderCreated = true;
                    red = 214;
                    green = 185;
                    blue = 108;
                }
            else if (count == 475)
                {
                    colorName = "Dill Seed";
                    orderCreated = true;
                    red = 179;
                    green = 177;
                    blue = 151;
                }
            else if (count == 476)
                {
                    colorName = "Private Jet";
                    orderCreated = true;
                    red = 128;
                    green = 175;
                    blue = 205;
                }
            else if (count == 477)
                {
                    colorName = "La Vie En Rose";
                    orderCreated = true;
                    red = 217;
                    green = 145;
                    blue = 147;
                }
            else if (count == 478)
                {
                    colorName = "Moss Print";
                    orderCreated = true;
                    red = 175;
                    green = 183;
                    blue = 151;
                }
            else if (count == 479)
                {
                    colorName = "Plum Taupe";
                    orderCreated = true;
                    red = 177;
                    green = 163;
                    blue = 170;
                }
            else if (count == 480)
                {
                    colorName = "Tart Apple";
                    orderCreated = true;
                    red = 174;
                    green = 248;
                    blue = 89;
                }
            else if (count == 481)
                {
                    colorName = "Perfect Sky";
                    orderCreated = true;
                    red = 76;
                    green = 180;
                    blue = 255;
                }
            else if (count == 482)
                {
                    colorName = "Lady Guinevere";
                    orderCreated = true;
                    red = 200;
                    green = 156;
                    blue = 156;
                }
            else if (count == 483)
                {
                    colorName = "Menthol";
                    orderCreated = true;
                    red = 115;
                    green = 254;
                    blue = 143;
                }
            else if (count == 484)
                {
                    colorName = "Desert Echo";
                    orderCreated = true;
                    red = 177;
                    green = 165;
                    blue = 171;
                }
            else if (count == 485)
                {
                    colorName = "Seedling";
                    orderCreated = true;
                    red = 184;
                    green = 179;
                    blue = 150;
                }
            else if (count == 486)
                {
                    colorName = "Power Gray";
                    orderCreated = true;
                    red = 156;
                    green = 175;
                    blue = 183;
                }
            else if (count == 487)
                {
                    colorName = "Modish Moss";
                    orderCreated = true;
                    red = 192;
                    green = 194;
                    blue = 129;
                }
            else if (count == 488)
                {
                    colorName = "Stone Walkway";
                    orderCreated = true;
                    red = 181;
                    green = 175;
                    blue = 159;
                }
            else if (count == 489)
                {
                    colorName = "Peachy Confection";
                    orderCreated = true;
                    red = 211;
                    green = 165;
                    blue = 140;
                }
            else if (count == 490)
                {
                    colorName = "Sweet Chrysanthemum";
                    orderCreated = true;
                    red = 221;
                    green = 132;
                    blue = 164;
                }
            else if (count == 491)
                {
                    colorName = "Minstrel Rose";
                    orderCreated = true;
                    red = 201;
                    green = 139;
                    blue = 177;
                }
            else if (count == 492)
                {
                    colorName = "Autumn Malt";
                    orderCreated = true;
                    red = 207;
                    green = 160;
                    blue = 151;
                }
            else if (count == 493)
                {
                    colorName = "Environmental";
                    orderCreated = true;
                    red = 176;
                    green = 181;
                    blue = 161;
                }
            else if (count == 494)
                {
                    colorName = "Butterfly Garden";
                    orderCreated = true;
                    red = 137;
                    green = 137;
                    blue = 245;
                }
            else if (count == 495)
                {
                    colorName = "Vast Desert";
                    orderCreated = true;
                    red = 193;
                    green = 175;
                    blue = 151;
                }
            else if (count == 496)
                {
                    colorName = "Still Gray";
                    orderCreated = true;
                    red = 168;
                    green = 183;
                    blue = 169;
                }
            else if (count == 497)
                {
                    colorName = "Harmonious";
                    orderCreated = true;
                    red = 155;
                    green = 181;
                    blue = 184;
                }
            else if (count == 498)
                {
                    colorName = "Dusty Rosewood";
                    orderCreated = true;
                    red = 191;
                    green = 169;
                    blue = 160;
                }
            else if (count == 499)
                {
                    colorName = "Soft Pebble";
                    orderCreated = true;
                    red = 174;
                    green = 173;
                    blue = 174;
                }
            else if (count == 500)
                {
                    colorName = "Basswood";
                    orderCreated = true;
                    red = 199;
                    green = 174;
                    blue = 149;
                }
            else if (count == 501)
                {
                    colorName = "Norwester";
                    orderCreated = true;
                    red = 147;
                    green = 188;
                    blue = 188;
                }
            else if (count == 502)
                {
                    colorName = "Pottery Wheel";
                    orderCreated = true;
                    red = 202;
                    green = 175;
                    blue = 147;
                }
            else if (count == 503)
                {
                    colorName = "Daylight Lilac";
                    orderCreated = true;
                    red = 158;
                    green = 124;
                    blue = 243;
                }
            else if (count == 504)
                {
                    colorName = "Prestige";
                    orderCreated = true;
                    red = 180;
                    green = 173;
                    blue = 173;
                }
            else if (count == 505)
                {
                    colorName = "Audition";
                    orderCreated = true;
                    red = 178;
                    green = 168;
                    blue = 180;
                }
            else if (count == 506)
                {
                    colorName = "Summer Field";
                    orderCreated = true;
                    red = 228;
                    green = 198;
                    blue = 101;
                }
            else if (count == 507)
                {
                    colorName = "Washed Denim";
                    orderCreated = true;
                    red = 123;
                    green = 178;
                    blue = 226;
                }
            else if (count == 508)
                {
                    colorName = "Tahoe Blue";
                    orderCreated = true;
                    red = 148;
                    green = 184;
                    blue = 195;
                }
            else if (count == 509)
                {
                    colorName = "Court Green";
                    orderCreated = true;
                    red = 184;
                    green = 182;
                    blue = 161;
                }
            else if (count == 510)
                {
                    colorName = "Peaceful River";
                    orderCreated = true;
                    red = 81;
                    green = 198;
                    blue = 249;
                }
            else if (count == 511)
                {
                    colorName = "Laurel Mist";
                    orderCreated = true;
                    red = 168;
                    green = 200;
                    blue = 161;
                }
            else if (count == 512)
                {
                    colorName = "Smiley Face";
                    orderCreated = true;
                    red = 255;
                    green = 199;
                    blue = 75;
                }
            else if (count == 513)
                {
                    colorName = "Pansy Garden";
                    orderCreated = true;
                    red = 122;
                    green = 153;
                    blue = 255;
                }
            else if (count == 514)
                {
                    colorName = "Gingko";
                    orderCreated = true;
                    red = 159;
                    green = 238;
                    blue = 134;
                }
            else if (count == 515)
                {
                    colorName = "Classic";
                    orderCreated = true;
                    red = 183;
                    green = 177;
                    blue = 172;
                }
            else if (count == 516)
                {
                    colorName = "Fuzzy Duckling";
                    orderCreated = true;
                    red = 255;
                    green = 198;
                    blue = 79;
                }
            else if (count == 517)
                {
                    colorName = "Gold Buff";
                    orderCreated = true;
                    red = 237;
                    green = 186;
                    blue = 110;
                }
            else if (count == 518)
                {
                    colorName = "Garden Vista";
                    orderCreated = true;
                    red = 155;
                    green = 199;
                    blue = 179;
                }
            else if (count == 519)
                {
                    colorName = "Vintage Mauve";
                    orderCreated = true;
                    red = 186;
                    green = 175;
                    blue = 173;
                }
            else if (count == 520)
                {
                    colorName = "Cellini Gold";
                    orderCreated = true;
                    red = 222;
                    green = 181;
                    blue = 132;
                }
            else if (count == 521)
                {
                    colorName = "Gulf Stream";
                    orderCreated = true;
                    red = 104;
                    green = 184;
                    blue = 248;
                }
            else if (count == 522)
                {
                    colorName = "Arizona Tan";
                    orderCreated = true;
                    red = 230;
                    green = 188;
                    blue = 119;
                }
            else if (count == 523)
                {
                    colorName = "Luscious Lemon";
                    orderCreated = true;
                    red = 239;
                    green = 190;
                    blue = 108;
                }
            else if (count == 524)
                {
                    colorName = "Smokestack";
                    orderCreated = true;
                    red = 191;
                    green = 179;
                    blue = 167;
                }
            else if (count == 525)
                {
                    colorName = "Mushroom Bisque";
                    orderCreated = true;
                    red = 201;
                    green = 180;
                    blue = 156;
                }
            else if (count == 526)
                {
                    colorName = "Not A Cloud In Sight";
                    orderCreated = true;
                    red = 131;
                    green = 197;
                    blue = 210;
                }
            else if (count == 527)
                {
                    colorName = "Mineral Yellow";
                    orderCreated = true;
                    red = 214;
                    green = 187;
                    blue = 138;
                }
            else if (count == 528)
                {
                    colorName = "Strawberry Rose";
                    orderCreated = true;
                    red = 232;
                    green = 137;
                    blue = 171;
                }
            else if (count == 529)
                {
                    colorName = "Fortune Cookie";
                    orderCreated = true;
                    red = 220;
                    green = 183;
                    blue = 137;
                }
            else if (count == 530)
                {
                    colorName = "Sea Life";
                    orderCreated = true;
                    red = 107;
                    green = 255;
                    blue = 180;
                }
            else if (count == 531)
                {
                    colorName = "Cest La Vie";
                    orderCreated = true;
                    red = 127;
                    green = 185;
                    blue = 230;
                }
            else if (count == 532)
                {
                    colorName = "Blue Suede";
                    orderCreated = true;
                    red = 155;
                    green = 181;
                    blue = 207;
                }
            else if (count == 533)
                {
                    colorName = "Urban Putty";
                    orderCreated = true;
                    red = 173;
                    green = 192;
                    blue = 179;
                }
            else if (count == 534)
                {
                    colorName = "Cloudberry";
                    orderCreated = true;
                    red = 148;
                    green = 182;
                    blue = 215;
                }
            else if (count == 535)
                {
                    colorName = "Cinnamon Cocoa";
                    orderCreated = true;
                    red = 211;
                    green = 164;
                    blue = 171;
                }
            else if (count == 536)
                {
                    colorName = "Restful";
                    orderCreated = true;
                    red = 183;
                    green = 202;
                    blue = 162;
                }
            else if (count == 537)
                {
                    colorName = "Royal Gold";
                    orderCreated = true;
                    red = 227;
                    green = 189;
                    blue = 131;
                }
            else if (count == 538)
                {
                    colorName = "Cool Aloe";
                    orderCreated = true;
                    red = 165;
                    green = 255;
                    blue = 128;
                }
            else if (count == 539)
                {
                    colorName = "Classic Bouquet";
                    orderCreated = true;
                    red = 160;
                    green = 133;
                    blue = 255;
                }
            else if (count == 540)
                {
                    colorName = "Koala Bear";
                    orderCreated = true;
                    red = 186;
                    green = 196;
                    blue = 167;
                }
            else if (count == 541)
                {
                    colorName = "Island Oasis";
                    orderCreated = true;
                    red = 132;
                    green = 213;
                    blue = 205;
                }
            else if (count == 542)
                {
                    colorName = "Apricot Flower";
                    orderCreated = true;
                    red = 255;
                    green = 176;
                    blue = 120;
                }
            else if (count == 543)
                {
                    colorName = "Lion";
                    orderCreated = true;
                    red = 198;
                    green = 198;
                    blue = 155;
                }
            else if (count == 544)
                {
                    colorName = "Lavender Wash";
                    orderCreated = true;
                    red = 168;
                    green = 173;
                    blue = 210;
                }
            else if (count == 545)
                {
                    colorName = "Spiced Butternut";
                    orderCreated = true;
                    red = 255;
                    green = 200;
                    blue = 97;
                }
            else if (count == 546)
                {
                    colorName = "Dew";
                    orderCreated = true;
                    red = 177;
                    green = 190;
                    blue = 185;
                }
            else if (count == 547)
                {
                    colorName = "Gentle Sky";
                    orderCreated = true;
                    red = 152;
                    green = 189;
                    blue = 211;
                }
            else if (count == 548)
                {
                    colorName = "Green Trance";
                    orderCreated = true;
                    red = 159;
                    green = 255;
                    blue = 139;
                }
            else if (count == 549)
                {
                    colorName = "Charismatic";
                    orderCreated = true;
                    red = 231;
                    green = 193;
                    blue = 129;
                }
            else if (count == 550)
                {
                    colorName = "Romantic Isle";
                    orderCreated = true;
                    red = 136;
                    green = 184;
                    blue = 234;
                }
            else if (count == 551)
                {
                    colorName = "Highland Thistle";
                    orderCreated = true;
                    red = 184;
                    green = 163;
                    blue = 207;
                }
            else if (count == 552)
                {
                    colorName = "Whitewater Bay";
                    orderCreated = true;
                    red = 185;
                    green = 196;
                    blue = 174;
                }
            else if (count == 553)
                {
                    colorName = "Veranda Iris";
                    orderCreated = true;
                    red = 155;
                    green = 176;
                    blue = 225;
                }
            else if (count == 554)
                {
                    colorName = "Chilly Blue";
                    orderCreated = true;
                    red = 135;
                    green = 200;
                    blue = 221;
                }
            else if (count == 555)
                {
                    colorName = "Pure Turquoise";
                    orderCreated = true;
                    red = 124;
                    green = 237;
                    blue = 196;
                }
            else if (count == 556)
                {
                    colorName = "Tropical Trail";
                    orderCreated = true;
                    red = 139;
                    green = 255;
                    blue = 164;
                }
            else if (count == 557)
                {
                    colorName = "Gobi Desert";
                    orderCreated = true;
                    red = 206;
                    green = 188;
                    blue = 165;
                }
            else if (count == 558)
                {
                    colorName = "Minted Lemon";
                    orderCreated = true;
                    red = 192;
                    green = 198;
                    blue = 169;
                }
            else if (count == 559)
                {
                    colorName = "Corn Husk Green";
                    orderCreated = true;
                    red = 203;
                    green = 224;
                    blue = 133;
                }
            else if (count == 560)
                {
                    colorName = "French Lilac";
                    orderCreated = true;
                    red = 189;
                    green = 184;
                    blue = 187;
                }
            else if (count == 561)
                {
                    colorName = "Frisky Blue";
                    orderCreated = true;
                    red = 125;
                    green = 212;
                    blue = 224;
                }
            else if (count == 562)
                {
                    colorName = "Feather Gold";
                    orderCreated = true;
                    red = 238;
                    green = 219;
                    blue = 105;
                }
            else if (count == 563)
                {
                    colorName = "Four Leaf Clover";
                    orderCreated = true;
                    red = 182;
                    green = 240;
                    blue = 140;
                }
            else if (count == 564)
                {
                    colorName = "Pumpkin Cream";
                    orderCreated = true;
                    red = 219;
                    green = 185;
                    blue = 158;
                }
            else if (count == 565)
                {
                    colorName = "Velveteen Crush";
                    orderCreated = true;
                    red = 208;
                    green = 173;
                    blue = 182;
                }
            else if (count == 566)
                {
                    colorName = "Simply Blue";
                    orderCreated = true;
                    red = 173;
                    green = 187;
                    blue = 203;
                }
            else if (count == 567)
                {
                    colorName = "Pewter Mug";
                    orderCreated = true;
                    red = 176;
                    green = 193;
                    blue = 195;
                }
            else if (count == 568)
                {
                    colorName = "Coral Gold";
                    orderCreated = true;
                    red = 255;
                    green = 175;
                    blue = 135;
                }
            else if (count == 569)
                {
                    colorName = "Rustic Rose";
                    orderCreated = true;
                    red = 203;
                    green = 188;
                    blue = 174;
                }
            else if (count == 570)
                {
                    colorName = "Subdued Hue";
                    orderCreated = true;
                    red = 197;
                    green = 179;
                    blue = 190;
                }
            else if (count == 571)
                {
                    colorName = "Marjoram";
                    orderCreated = true;
                    red = 188;
                    green = 228;
                    blue = 150;
                }
            else if (count == 572)
                {
                    colorName = "Aster";
                    orderCreated = true;
                    red = 190;
                    green = 183;
                    blue = 193;
                }
            else if (count == 573)
                {
                    colorName = "Concept Beige";
                    orderCreated = true;
                    red = 213;
                    green = 189;
                    blue = 165;
                }
            else if (count == 574)
                {
                    colorName = "Desert Sunrise";
                    orderCreated = true;
                    red = 255;
                    green = 167;
                    blue = 146;
                }
            else if (count == 575)
                {
                    colorName = "Gull Gray";
                    orderCreated = true;
                    red = 191;
                    green = 191;
                    blue = 186;
                }
            else if (count == 576)
                {
                    colorName = "Orange Grove";
                    orderCreated = true;
                    red = 255;
                    green = 161;
                    blue = 153;
                }
            else if (count == 577)
                {
                    colorName = "Coco";
                    orderCreated = true;
                    red = 209;
                    green = 193;
                    blue = 167;
                }
            else if (count == 578)
                {
                    colorName = "Canyon Mist";
                    orderCreated = true;
                    red = 167;
                    green = 172;
                    blue = 231;
                }
            else if (count == 579)
                {
                    colorName = "Flagstaff Green";
                    orderCreated = true;
                    red = 177;
                    green = 212;
                    blue = 181;
                }
            else if (count == 580)
                {
                    colorName = "Finesse";
                    orderCreated = true;
                    red = 149;
                    green = 185;
                    blue = 237;
                }
            else if (count == 581)
                {
                    colorName = "Washed Khaki";
                    orderCreated = true;
                    red = 202;
                    green = 193;
                    blue = 176;
                }
            else if (count == 582)
                {
                    colorName = "Baja";
                    orderCreated = true;
                    red = 210;
                    green = 193;
                    blue = 169;
                }
            else if (count == 583)
                {
                    colorName = "Passion Fruit Punch";
                    orderCreated = true;
                    red = 238;
                    green = 158;
                    blue = 177;
                }
            else if (count == 584)
                {
                    colorName = "Movie Magic";
                    orderCreated = true;
                    red = 176;
                    green = 187;
                    blue = 211;
                }
            else if (count == 585)
                {
                    colorName = "Springtime Bloom";
                    orderCreated = true;
                    red = 228;
                    green = 111;
                    blue = 236;
                }
            else if (count == 586)
                {
                    colorName = "Armadillo";
                    orderCreated = true;
                    red = 200;
                    green = 193;
                    blue = 182;
                }
            else if (count == 587)
                {
                    colorName = "Winter Garden";
                    orderCreated = true;
                    red = 219;
                    green = 206;
                    blue = 151;
                }
            else if (count == 588)
                {
                    colorName = "Cinnamon Whip";
                    orderCreated = true;
                    red = 220;
                    green = 178;
                    blue = 179;
                }
            else if (count == 589)
                {
                    colorName = "Pink Eraser";
                    orderCreated = true;
                    red = 253;
                    green = 141;
                    blue = 184;
                }
            else if (count == 590)
                {
                    colorName = "Blue Echo";
                    orderCreated = true;
                    red = 142;
                    green = 220;
                    blue = 216;
                }
            else if (count == 591)
                {
                    colorName = "Key Lime";
                    orderCreated = true;
                    red = 199;
                    green = 253;
                    blue = 127;
                }
            else if (count == 592)
                {
                    colorName = "Vanity";
                    orderCreated = true;
                    red = 176;
                    green = 193;
                    blue = 210;
                }
            else if (count == 593)
                {
                    colorName = "Duchess Rose";
                    orderCreated = true;
                    red = 255;
                    green = 154;
                    blue = 171;
                }
            else if (count == 594)
                {
                    colorName = "Tanglewood";
                    orderCreated = true;
                    red = 194;
                    green = 201;
                    blue = 185;
                }
            else if (count == 595)
                {
                    colorName = "Powdered Petals";
                    orderCreated = true;
                    red = 248;
                    green = 158;
                    blue = 175;
                }
            else if (count == 596)
                {
                    colorName = "Sculptor Clay";
                    orderCreated = true;
                    red = 204;
                    green = 195;
                    blue = 182;
                }
            else if (count == 597)
                {
                    colorName = "Bellflower";
                    orderCreated = true;
                    red = 161;
                    green = 191;
                    blue = 231;
                }
            else if (count == 598)
                {
                    colorName = "Ash Blonde";
                    orderCreated = true;
                    red = 216;
                    green = 195;
                    blue = 172;
                }
            else if (count == 599)
                {
                    colorName = "Riviera Retreat";
                    orderCreated = true;
                    red = 217;
                    green = 196;
                    blue = 171;
                }
            else if (count == 600)
                {
                    colorName = "Ocean Foam";
                    orderCreated = true;
                    red = 202;
                    green = 200;
                    blue = 182;
                }
            else if (count == 601)
                {
                    colorName = "Pecan Sandie";
                    orderCreated = true;
                    red = 209;
                    green = 198;
                    blue = 178;
                }
            else if (count == 602)
                {
                    colorName = "Healing Aloe";
                    orderCreated = true;
                    red = 182;
                    green = 228;
                    blue = 175;
                }
            else if (count == 603)
                {
                    colorName = "Honeydew";
                    orderCreated = true;
                    red = 218;
                    green = 251;
                    blue = 117;
                }
            else if (count == 604)
                {
                    colorName = "Light Year";
                    orderCreated = true;
                    red = 191;
                    green = 205;
                    blue = 190;
                }
            else if (count == 605)
                {
                    colorName = "Rosy Outlook";
                    orderCreated = true;
                    red = 252;
                    green = 155;
                    blue = 180;
                }
            else if (count == 606)
                {
                    colorName = "Raspberry Smoothie";
                    orderCreated = true;
                    red = 212;
                    green = 153;
                    blue = 222;
                }
            else if (count == 607)
                {
                    colorName = "Crepe";
                    orderCreated = true;
                    red = 224;
                    green = 201;
                    blue = 162;
                }
            else if (count == 608)
                {
                    colorName = "French Beige";
                    orderCreated = true;
                    red = 212;
                    green = 197;
                    blue = 179;
                }
            else if (count == 609)
                {
                    colorName = "Honey Beige";
                    orderCreated = true;
                    red = 231;
                    green = 221;
                    blue = 137;
                }
            else if (count == 610)
                {
                    colorName = "Pale Ivy";
                    orderCreated = true;
                    red = 210;
                    green = 204;
                    blue = 175;
                }
            else if (count == 611)
                {
                    colorName = "Sienna Dust";
                    orderCreated = true;
                    red = 220;
                    green = 196;
                    blue = 173;
                }
            else if (count == 612)
                {
                    colorName = "Silver Sateen";
                    orderCreated = true;
                    red = 199;
                    green = 197;
                    blue = 193;
                }
            else if (count == 613)
                {
                    colorName = "Best In Show";
                    orderCreated = true;
                    red = 185;
                    green = 195;
                    blue = 210;
                }
            else if (count == 614)
                {
                    colorName = "Soothing Spring";
                    orderCreated = true;
                    red = 189;
                    green = 203;
                    blue = 199;
                }
            else if (count == 615)
                {
                    colorName = "Future Vision";
                    orderCreated = true;
                    red = 189;
                    green = 192;
                    blue = 210;
                }
            else if (count == 616)
                {
                    colorName = "Yellow Brick Road";
                    orderCreated = true;
                    red = 254;
                    green = 223;
                    blue = 115;
                }
            else if (count == 617)
                {
                    colorName = "Apple Blossom";
                    orderCreated = true;
                    red = 230;
                    green = 156;
                    blue = 206;
                }
            else if (count == 618)
                {
                    colorName = "Caspian Tide";
                    orderCreated = true;
                    red = 173;
                    green = 199;
                    blue = 220;
                }
            else if (count == 619)
                {
                    colorName = "Reef Blue";
                    orderCreated = true;
                    red = 148;
                    green = 220;
                    blue = 225;
                }
            else if (count == 620)
                {
                    colorName = "Ocean Kiss";
                    orderCreated = true;
                    red = 165;
                    green = 222;
                    blue = 207;
                }
            else if (count == 621)
                {
                    colorName = "Embroidery";
                    orderCreated = true;
                    red = 212;
                    green = 190;
                    blue = 192;
                }
            else if (count == 622)
                {
                    colorName = "Standing Ovation";
                    orderCreated = true;
                    red = 191;
                    green = 195;
                    blue = 209;
                }
            else if (count == 623)
                {
                    colorName = "Marina Isle";
                    orderCreated = true;
                    red = 176;
                    green = 224;
                    blue = 196;
                }
            else if (count == 624)
                {
                    colorName = "Partly Cloudy";
                    orderCreated = true;
                    red = 158;
                    green = 212;
                    blue = 226;
                }
            else if (count == 625)
                {
                    colorName = "Down Home";
                    orderCreated = true;
                    red = 201;
                    green = 198;
                    blue = 198;
                }
            else if (count == 626)
                {
                    colorName = "Bella Mia";
                    orderCreated = true;
                    red = 217;
                    green = 194;
                    blue = 187;
                }
            else if (count == 627)
                {
                    colorName = "Coral Stone";
                    orderCreated = true;
                    red = 221;
                    green = 194;
                    blue = 183;
                }
            else if (count == 628)
                {
                    colorName = "Sandstone Cliff";
                    orderCreated = true;
                    red = 211;
                    green = 202;
                    blue = 186;
                }
            else if (count == 629)
                {
                    colorName = "Chinese Jade";
                    orderCreated = true;
                    red = 203;
                    green = 209;
                    blue = 187;
                }
            else if (count == 630)
                {
                    colorName = "Cornflower Blue";
                    orderCreated = true;
                    red = 149;
                    green = 199;
                    blue = 252;
                }
            else if (count == 631)
                {
                    colorName = "Shanghai Jade";
                    orderCreated = true;
                    red = 171;
                    green = 255;
                    blue = 174;
                }
            else if (count == 632)
                {
                    colorName = "Apricot Light";
                    orderCreated = true;
                    red = 255;
                    green = 197;
                    blue = 149;
                }
            else if (count == 633)
                {
                    colorName = "Sunkissed Apricot";
                    orderCreated = true;
                    red = 242;
                    green = 189;
                    blue = 170;
                }
            else if (count == 634)
                {
                    colorName = "Rainwater";
                    orderCreated = true;
                    red = 144;
                    green = 255;
                    blue = 202;
                }
            else if (count == 635)
                {
                    colorName = "Reviving Green";
                    orderCreated = true;
                    red = 231;
                    green = 239;
                    blue = 132;
                }
            else if (count == 636)
                {
                    colorName = "Bicycle Yellow";
                    orderCreated = true;
                    red = 253;
                    green = 234;
                    blue = 116;
                }
            else if (count == 637)
                {
                    colorName = "Sandstorm";
                    orderCreated = true;
                    red = 207;
                    green = 209;
                    blue = 187;
                }
            else if (count == 638)
                {
                    colorName = "Candy Coated";
                    orderCreated = true;
                    red = 250;
                    green = 139;
                    blue = 215;
                }
            else if (count == 639)
                {
                    colorName = "Love At First Sight";
                    orderCreated = true;
                    red = 236;
                    green = 151;
                    blue = 217;
                }
            else if (count == 640)
                {
                    colorName = "Regal";
                    orderCreated = true;
                    red = 218;
                    green = 198;
                    blue = 189;
                }
            else if (count == 641)
                {
                    colorName = "Mulberry Stain";
                    orderCreated = true;
                    red = 199;
                    green = 193;
                    blue = 213;
                }
            else if (count == 642)
                {
                    colorName = "Arabian Sands";
                    orderCreated = true;
                    red = 221;
                    green = 201;
                    blue = 184;
                }
            else if (count == 643)
                {
                    colorName = "Wintergreen Dream";
                    orderCreated = true;
                    red = 176;
                    green = 235;
                    blue = 195;
                }
            else if (count == 644)
                {
                    colorName = "Veronese Peach";
                    orderCreated = true;
                    red = 241;
                    green = 185;
                    blue = 181;
                }
            else if (count == 645)
                {
                    colorName = "Wisp Of Mauve";
                    orderCreated = true;
                    red = 217;
                    green = 199;
                    blue = 191;
                }
            else if (count == 646)
                {
                    colorName = "Viking";
                    orderCreated = true;
                    red = 166;
                    green = 218;
                    blue = 224;
                }
            else if (count == 647)
                {
                    colorName = "Doeskin Gray";
                    orderCreated = true;
                    red = 205;
                    green = 206;
                    blue = 197;
                }
            else if (count == 648)
                {
                    colorName = "Pink Beach";
                    orderCreated = true;
                    red = 250;
                    green = 187;
                    blue = 172;
                }
            else if (count == 649)
                {
                    colorName = "Costa Rica Blue";
                    orderCreated = true;
                    red = 129;
                    green = 229;
                    blue = 251;
                }
            else if (count == 650)
                {
                    colorName = "Mountain Falls";
                    orderCreated = true;
                    red = 189;
                    green = 222;
                    blue = 198;
                }
            else if (count == 651)
                {
                    colorName = "Springday";
                    orderCreated = true;
                    red = 218;
                    green = 212;
                    blue = 180;
                }
            else if (count == 652)
                {
                    colorName = "Crystal Waters";
                    orderCreated = true;
                    red = 179;
                    green = 206;
                    blue = 225;
                }
            else if (count == 653)
                {
                    colorName = "Sweet Jasmine";
                    orderCreated = true;
                    red = 220;
                    green = 220;
                    blue = 171;
                }
            else if (count == 654)
                {
                    colorName = "Burnished Clay";
                    orderCreated = true;
                    red = 210;
                    green = 204;
                    blue = 197;
                }
            else if (count == 655)
                {
                    colorName = "Cotton Grey";
                    orderCreated = true;
                    red = 210;
                    green = 204;
                    blue = 198;
                }
            else if (count == 656)
                {
                    colorName = "Sea Of Tranquility";
                    orderCreated = true;
                    red = 137;
                    green = 255;
                    blue = 220;
                }
            else if (count == 657)
                {
                    colorName = "Sweet Apricot";
                    orderCreated = true;
                    red = 255;
                    green = 181;
                    blue = 178;
                }
            else if (count == 658)
                {
                    colorName = "Coral Coast";
                    orderCreated = true;
                    red = 235;
                    green = 197;
                    blue = 182;
                }
            else if (count == 659)
                {
                    colorName = "Fish Pond";
                    orderCreated = true;
                    red = 161;
                    green = 255;
                    blue = 198;
                }
            else if (count == 660)
                {
                    colorName = "Amber Moon";
                    orderCreated = true;
                    red = 239;
                    green = 209;
                    blue = 167;
                }
            else if (count == 661)
                {
                    colorName = "Pixie Violet";
                    orderCreated = true;
                    red = 176;
                    green = 188;
                    blue = 252;
                }
            else if (count == 662)
                {
                    colorName = "Pale Cucumber";
                    orderCreated = true;
                    red = 214;
                    green = 213;
                    blue = 189;
                }
            else if (count == 663)
                {
                    colorName = "Geranium Bud";
                    orderCreated = true;
                    red = 213;
                    green = 150;
                    blue = 254;
                }
            else if (count == 664)
                {
                    colorName = "Sweet Breeze";
                    orderCreated = true;
                    red = 214;
                    green = 198;
                    blue = 206;
                }
            else if (count == 665)
                {
                    colorName = "Boot Cut";
                    orderCreated = true;
                    red = 176;
                    green = 214;
                    blue = 228;
                }
            else if (count == 666)
                {
                    colorName = "Honest";
                    orderCreated = true;
                    red = 159;
                    green = 205;
                    blue = 255;
                }
            else if (count == 667)
                {
                    colorName = "Dolphin Fin";
                    orderCreated = true;
                    red = 204;
                    green = 214;
                    blue = 202;
                }
            else if (count == 668)
                {
                    colorName = "Big Chill";
                    orderCreated = true;
                    red = 135;
                    green = 248;
                    blue = 237;
                }
            else if (count == 669)
                {
                    colorName = "Oceanic Climate";
                    orderCreated = true;
                    red = 188;
                    green = 218;
                    blue = 215;
                }
            else if (count == 670)
                {
                    colorName = "Freesia Purple";
                    orderCreated = true;
                    red = 183;
                    green = 184;
                    blue = 255;
                }
            else if (count == 671)
                {
                    colorName = "Old Map";
                    orderCreated = true;
                    red = 215;
                    green = 208;
                    blue = 199;
                }
            else if (count == 672)
                {
                    colorName = "Breathe";
                    orderCreated = true;
                    red = 210;
                    green = 226;
                    blue = 186;
                }
            else if (count == 673)
                {
                    colorName = "Charismatic Sky";
                    orderCreated = true;
                    red = 158;
                    green = 221;
                    blue = 244;
                }
            else if (count == 674)
                {
                    colorName = "Sweet Nectar";
                    orderCreated = true;
                    red = 255;
                    green = 174;
                    blue = 195;
                }
            else if (count == 675)
                {
                    colorName = "Peridot";
                    orderCreated = true;
                    red = 204;
                    green = 247;
                    blue = 173;
                }
            else if (count == 676)
                {
                    colorName = "Yellowstone";
                    orderCreated = true;
                    red = 232;
                    green = 213;
                    blue = 179;
                }
            else if (count == 677)
                {
                    colorName = "Roasted Corn";
                    orderCreated = true;
                    red = 254;
                    green = 231;
                    blue = 140;
                }
            else if (count == 678)
                {
                    colorName = "Arizona Sunrise";
                    orderCreated = true;
                    red = 239;
                    green = 179;
                    blue = 208;
                }
            else if (count == 679)
                {
                    colorName = "Pale Orchid";
                    orderCreated = true;
                    red = 202;
                    green = 170;
                    blue = 254;
                }
            else if (count == 680)
                {
                    colorName = "Sand Pearl";
                    orderCreated = true;
                    red = 231;
                    green = 211;
                    blue = 184;
                }
            else if (count == 681)
                {
                    colorName = "Shortbread Cookie";
                    orderCreated = true;
                    red = 237;
                    green = 208;
                    blue = 182;
                }
            else if (count == 682)
                {
                    colorName = "Chai";
                    orderCreated = true;
                    red = 238;
                    green = 211;
                    blue = 178;
                }
            else if (count == 683)
                {
                    colorName = "Calm Air";
                    orderCreated = true;
                    red = 240;
                    green = 213;
                    blue = 175;
                }
            else if (count == 684)
                {
                    colorName = "Pale Honey";
                    orderCreated = true;
                    red = 244;
                    green = 213;
                    blue = 171;
                }
            else if (count == 685)
                {
                    colorName = "Vitamin C";
                    orderCreated = true;
                    red = 255;
                    green = 207;
                    blue = 167;
                }
            else if (count == 686)
                {
                    colorName = "Pink Taffy";
                    orderCreated = true;
                    red = 245;
                    green = 178;
                    blue = 207;
                }
            else if (count == 687)
                {
                    colorName = "Lemon Balm";
                    orderCreated = true;
                    red = 229;
                    green = 217;
                    blue = 184;
                }
            else if (count == 688)
                {
                    colorName = "Botanical Tint";
                    orderCreated = true;
                    red = 174;
                    green = 255;
                    blue = 202;
                }
            else if (count == 689)
                {
                    colorName = "Sea Wind";
                    orderCreated = true;
                    red = 174;
                    green = 229;
                    blue = 228;
                }
            else if (count == 690)
                {
                    colorName = "Green Myth";
                    orderCreated = true;
                    red = 196;
                    green = 251;
                    blue = 185;
                }
            else if (count == 691)
                {
                    colorName = "Champagne Wishes";
                    orderCreated = true;
                    red = 242;
                    green = 216;
                    blue = 174;
                }
            else if (count == 692)
                {
                    colorName = "Stonewashed";
                    orderCreated = true;
                    red = 220;
                    green = 214;
                    blue = 198;
                }
            else if (count == 693)
                {
                    colorName = "Luminary";
                    orderCreated = true;
                    red = 255;
                    green = 205;
                    blue = 173;
                }
            else if (count == 694)
                {
                    colorName = "Ice Cream Parlour";
                    orderCreated = true;
                    red = 249;
                    green = 209;
                    blue = 175;
                }
            else if (count == 695)
                {
                    colorName = "Spirited Green";
                    orderCreated = true;
                    red = 189;
                    green = 251;
                    blue = 194;
                }
            else if (count == 696)
                {
                    colorName = "Offshore Mist";
                    orderCreated = true;
                    red = 202;
                    green = 215;
                    blue = 217;
                }
            else if (count == 697)
                {
                    colorName = "Stucco White";
                    orderCreated = true;
                    red = 228;
                    green = 218;
                    blue = 189;
                }
            else if (count == 698)
                {
                    colorName = "Clamshell";
                    orderCreated = true;
                    red = 240;
                    green = 208;
                    blue = 188;
                }
            else if (count == 699)
                {
                    colorName = "Sky Light View";
                    orderCreated = true;
                    red = 200;
                    green = 215;
                    blue = 221;
                }
            else if (count == 700)
                {
                    colorName = "Soft Shoe";
                    orderCreated = true;
                    red = 231;
                    green = 210;
                    blue = 196;
                }
            else if (count == 701)
                {
                    colorName = "Lavender Honor";
                    orderCreated = true;
                    red = 194;
                    green = 206;
                    blue = 237;
                }
            else if (count == 702)
                {
                    colorName = "Cream Custard";
                    orderCreated = true;
                    red = 245;
                    green = 217;
                    blue = 176;
                }
            else if (count == 703)
                {
                    colorName = "Rivers Edge";
                    orderCreated = true;
                    red = 174;
                    green = 249;
                    blue = 216;
                }
            else if (count == 704)
                {
                    colorName = "Writer's Parchment";
                    orderCreated = true;
                    red = 233;
                    green = 214;
                    blue = 192;
                }
            else if (count == 705)
                {
                    colorName = "Mocha Light";
                    orderCreated = true;
                    red = 218;
                    green = 218;
                    blue = 204;
                }
            else if (count == 706)
                {
                    colorName = "Rosewater";
                    orderCreated = true;
                    red = 230;
                    green = 201;
                    blue = 209;
                }
            else if (count == 707)
                {
                    colorName = "Grape Lavender";
                    orderCreated = true;
                    red = 197;
                    green = 207;
                    blue = 237;
                }
            else if (count == 708)
                {
                    colorName = "Wave Top";
                    orderCreated = true;
                    red = 178;
                    green = 250;
                    blue = 214;
                }
            else if (count == 709)
                {
                    colorName = "Adobe Sand";
                    orderCreated = true;
                    red = 227;
                    green = 215;
                    blue = 200;
                }
            else if (count == 710)
                {
                    colorName = "Serene Peach";
                    orderCreated = true;
                    red = 248;
                    green = 208;
                    blue = 187;
                }
            else if (count == 711)
                {
                    colorName = "Loft Space";
                    orderCreated = true;
                    red = 205;
                    green = 220;
                    blue = 218;
                }
            else if (count == 712)
                {
                    colorName = "Windsong";
                    orderCreated = true;
                    red = 243;
                    green = 235;
                    blue = 166;
                }
            else if (count == 713)
                {
                    colorName = "Irish Folklore";
                    orderCreated = true;
                    red = 210;
                    green = 250;
                    blue = 184;
                }
            else if (count == 714)
                {
                    colorName = "Valley Mist";
                    orderCreated = true;
                    red = 202;
                    green = 232;
                    blue = 211;
                }
            else if (count == 715)
                {
                    colorName = "Early September";
                    orderCreated = true;
                    red = 177;
                    green = 232;
                    blue = 236;
                }
            else if (count == 716)
                {
                    colorName = "Lime Bright";
                    orderCreated = true;
                    red = 242;
                    green = 237;
                    blue = 166;
                }
            else if (count == 717)
                {
                    colorName = "Plantation Tan";
                    orderCreated = true;
                    red = 236;
                    green = 216;
                    blue = 194;
                }
            else if (count == 718)
                {
                    colorName = "April Mist";
                    orderCreated = true;
                    red = 206;
                    green = 235;
                    blue = 206;
                }
            else if (count == 719)
                {
                    colorName = "Apricot Freeze";
                    orderCreated = true;
                    red = 248;
                    green = 204;
                    blue = 195;
                }
            else if (count == 720)
                {
                    colorName = "Celtic Gray";
                    orderCreated = true;
                    red = 200;
                    green = 232;
                    blue = 216;
                }
            else if (count == 721)
                {
                    colorName = "Serene Thought";
                    orderCreated = true;
                    red = 164;
                    green = 255;
                    blue = 229;
                }
            else if (count == 722)
                {
                    colorName = "Light Incense";
                    orderCreated = true;
                    red = 238;
                    green = 219;
                    blue = 191;
                }
            else if (count == 723)
                {
                    colorName = "Silver Drop";
                    orderCreated = true;
                    red = 221;
                    green = 218;
                    blue = 210;
                }
            else if (count == 724)
                {
                    colorName = "Urban Mist";
                    orderCreated = true;
                    red = 211;
                    green = 219;
                    blue = 219;
                }
            else if (count == 725)
                {
                    colorName = "Summer Sky";
                    orderCreated = true;
                    red = 197;
                    green = 218;
                    blue = 235;
                }
            else if (count == 726)
                {
                    colorName = "Yellow Wax Pepper";
                    orderCreated = true;
                    red = 237;
                    green = 228;
                    blue = 185;
                }
            else if (count == 727)
                {
                    colorName = "Lemon Souffle";
                    orderCreated = true;
                    red = 254;
                    green = 236;
                    blue = 161;
                }
            else if (count == 728)
                {
                    colorName = "Jodhpur Tan";
                    orderCreated = true;
                    red = 221;
                    green = 217;
                    blue = 213;
                }
            else if (count == 729)
                {
                    colorName = "Mystic Fairy";
                    orderCreated = true;
                    red = 221;
                    green = 212;
                    blue = 218;
                }
            else if (count == 730)
                {
                    colorName = "Belvedere Cream";
                    orderCreated = true;
                    red = 227;
                    green = 228;
                    blue = 197;
                }
            else if (count == 731)
                {
                    colorName = "Feather Plume";
                    orderCreated = true;
                    red = 255;
                    green = 218;
                    blue = 180;
                }
            else if (count == 732)
                {
                    colorName = "Miami Stucco";
                    orderCreated = true;
                    red = 248;
                    green = 213;
                    blue = 192;
                }
            else if (count == 733)
                {
                    colorName = "Cherubic";
                    orderCreated = true;
                    red = 236;
                    green = 200;
                    blue = 217;
                }
            else if (count == 734)
                {
                    colorName = "California Lilac";
                    orderCreated = true;
                    red = 190;
                    green = 211;
                    blue = 253;
                }
            else if (count == 735)
                {
                    colorName = "Coconut Ice";
                    orderCreated = true;
                    red = 223;
                    green = 221;
                    blue = 210;
                }
            else if (count == 736)
                {
                    colorName = "Sentimental Beige";
                    orderCreated = true;
                    red = 226;
                    green = 225;
                    blue = 203;
                }
            else if (count == 737)
                {
                    colorName = "Golden Pastel";
                    orderCreated = true;
                    red = 247;
                    green = 218;
                    blue = 190;
                }
            else if (count == 738)
                {
                    colorName = "Monaco";
                    orderCreated = true;
                    red = 174;
                    green = 241;
                    blue = 241;
                }
            else if (count == 739)
                {
                    colorName = "Moth Gray";
                    orderCreated = true;
                    red = 221;
                    green = 221;
                    blue = 214;
                }
            else if (count == 740)
                {
                    colorName = "Spring Song";
                    orderCreated = true;
                    red = 253;
                    green = 195;
                    blue = 209;
                }
            else if (count == 741)
                {
                    colorName = "Time Out";
                    orderCreated = true;
                    red = 251;
                    green = 222;
                    blue = 184;
                }
            else if (count == 742)
                {
                    colorName = "Whitened Sage";
                    orderCreated = true;
                    red = 222;
                    green = 224;
                    blue = 211;
                }
            else if (count == 743)
                {
                    colorName = "Little Pond";
                    orderCreated = true;
                    red = 170;
                    green = 237;
                    blue = 251;
                }
            else if (count == 744)
                {
                    colorName = "Folly";
                    orderCreated = true;
                    red = 223;
                    green = 226;
                    blue = 209;
                }
            else if (count == 745)
                {
                    colorName = "Navajo White 1822";
                    orderCreated = true;
                    red = 236;
                    green = 226;
                    blue = 197;
                }
            else if (count == 746)
                {
                    colorName = "Moxie";
                    orderCreated = true;
                    red = 228;
                    green = 216;
                    blue = 215;
                }
            else if (count == 747)
                {
                    colorName = "Gumball";
                    orderCreated = true;
                    red = 239;
                    green = 165;
                    blue = 255;
                }
            else if (count == 748)
                {
                    colorName = "Antique White";
                    orderCreated = true;
                    red = 231;
                    green = 226;
                    blue = 202;
                }
            else if (count == 749)
                {
                    colorName = "Vanilla Ice Cream";
                    orderCreated = true;
                    red = 255;
                    green = 232;
                    blue = 173;
                }
            else if (count == 750)
                {
                    colorName = "Eminence";
                    orderCreated = true;
                    red = 196;
                    green = 230;
                    blue = 235;
                }
            else if (count == 751)
                {
                    colorName = "Pink Punch";
                    orderCreated = true;
                    red = 252;
                    green = 173;
                    blue = 237;
                }
            else if (count == 752)
                {
                    colorName = "Serene Journey";
                    orderCreated = true;
                    red = 210;
                    green = 234;
                    blue = 218;
                }
            else if (count == 753)
                {
                    colorName = "Golden Nectar";
                    orderCreated = true;
                    red = 255;
                    green = 229;
                    blue = 178;
                }
            else if (count == 754)
                {
                    colorName = "Shrimp Cocktail";
                    orderCreated = true;
                    red = 255;
                    green = 212;
                    blue = 196;
                }
            else if (count == 755)
                {
                    colorName = "Phoenix Villa";
                    orderCreated = true;
                    red = 242;
                    green = 223;
                    blue = 198;
                }
            else if (count == 756)
                {
                    colorName = "Cotton Knit";
                    orderCreated = true;
                    red = 229;
                    green = 223;
                    blue = 211;
                }
            else if (count == 757)
                {
                    colorName = "Velvet Sky";
                    orderCreated = true;
                    red = 200;
                    green = 226;
                    blue = 238;
                }
            else if (count == 758)
                {
                    colorName = "Rose Pearl";
                    orderCreated = true;
                    red = 226;
                    green = 220;
                    blue = 218;
                }
            else if (count == 759)
                {
                    colorName = "Feldspar";
                    orderCreated = true;
                    red = 232;
                    green = 248;
                    blue = 185;
                }
            else if (count == 760)
                {
                    colorName = "Pinch Of Pearl";
                    orderCreated = true;
                    red = 251;
                    green = 220;
                    blue = 194;
                }
            else if (count == 761)
                {
                    colorName = "Crushed Peony";
                    orderCreated = true;
                    red = 227;
                    green = 220;
                    blue = 218;
                }
            else if (count == 762)
                {
                    colorName = "Cornsilk";
                    orderCreated = true;
                    red = 254;
                    green = 235;
                    blue = 177;
                }
            else if (count == 763)
                {
                    colorName = "Faint Peach";
                    orderCreated = true;
                    red = 245;
                    green = 221;
                    blue = 200;
                }
            else if (count == 764)
                {
                    colorName = "Full Bloom";
                    orderCreated = true;
                    red = 255;
                    green = 197;
                    blue = 215;
                }
            else if (count == 765)
                {
                    colorName = "Campfire Ash";
                    orderCreated = true;
                    red = 223;
                    green = 228;
                    blue = 216;
                }
            else if (count == 766)
                {
                    colorName = "Comforting Green";
                    orderCreated = true;
                    red = 214;
                    green = 244;
                    blue = 209;
                }
            else if (count == 767)
                {
                    colorName = "Lilac Mauve";
                    orderCreated = true;
                    red = 218;
                    green = 216;
                    blue = 234;
                }
            else if (count == 768)
                {
                    colorName = "Pale Cashmere";
                    orderCreated = true;
                    red = 232;
                    green = 222;
                    blue = 214;
                }
            else if (count == 769)
                {
                    colorName = "Stable Hay";
                    orderCreated = true;
                    red = 249;
                    green = 227;
                    blue = 193;
                }
            else if (count == 770)
                {
                    colorName = "Silver Ash";
                    orderCreated = true;
                    red = 223;
                    green = 230;
                    blue = 216;
                }
            else if (count == 771)
                {
                    colorName = "Firefly";
                    orderCreated = true;
                    red = 253;
                    green = 247;
                    blue = 169;
                }
            else if (count == 772)
                {
                    colorName = "Lime Light";
                    orderCreated = true;
                    red = 214;
                    green = 237;
                    blue = 219;
                }
            else if (count == 773)
                {
                    colorName = "Crystalline Falls";
                    orderCreated = true;
                    red = 216;
                    green = 228;
                    blue = 226;
                }
            else if (count == 774)
                {
                    colorName = "Cream Puff";
                    orderCreated = true;
                    red = 244;
                    green = 227;
                    blue = 199;
                }
            else if (count == 775)
                {
                    colorName = "Lambskin";
                    orderCreated = true;
                    red = 237;
                    green = 225;
                    blue = 209;
                }
            else if (count == 776)
                {
                    colorName = "Creme Fraiche";
                    orderCreated = true;
                    red = 236;
                    green = 224;
                    blue = 211;
                }
            else if (count == 777)
                {
                    colorName = "New Harvest Moon";
                    orderCreated = true;
                    red = 239;
                    green = 229;
                    blue = 204;
                }
            else if (count == 778)
                {
                    colorName = "Mirror Ball";
                    orderCreated = true;
                    red = 217;
                    green = 222;
                    blue = 233;
                }
            else if (count == 779)
                {
                    colorName = "Antique Pearl";
                    orderCreated = true;
                    red = 239;
                    green = 217;
                    blue = 217;
                }
            else if (count == 780)
                {
                    colorName = "Light Granite";
                    orderCreated = true;
                    red = 228;
                    green = 231;
                    blue = 214;
                }
            else if (count == 781)
                {
                    colorName = "Mauve Mist";
                    orderCreated = true;
                    red = 225;
                    green = 218;
                    blue = 231;
                }
            else if (count == 782)
                {
                    colorName = "Cumberland Fog";
                    orderCreated = true;
                    red = 209;
                    green = 230;
                    blue = 235;
                }
            else if (count == 783)
                {
                    colorName = "Polished";
                    orderCreated = true;
                    red = 228;
                    green = 226;
                    blue = 220;
                }
            else if (count == 784)
                {
                    colorName = "Country Breeze";
                    orderCreated = true;
                    red = 226;
                    green = 223;
                    blue = 226;
                }
            else if (count == 785)
                {
                    colorName = "Rio Sky";
                    orderCreated = true;
                    red = 204;
                    green = 249;
                    blue = 222;
                }
            else if (count == 786)
                {
                    colorName = "Rich Cream";
                    orderCreated = true;
                    red = 249;
                    green = 238;
                    blue = 189;
                }
            else if (count == 787)
                {
                    colorName = "Silver Feather";
                    orderCreated = true;
                    red = 222;
                    green = 233;
                    blue = 221;
                }
            else if (count == 788)
                {
                    colorName = "Tinted Ice";
                    orderCreated = true;
                    red = 194;
                    green = 238;
                    blue = 244;
                }
            else if (count == 789)
                {
                    colorName = "Pacific Panorama";
                    orderCreated = true;
                    red = 193;
                    green = 232;
                    blue = 252;
                }
            else if (count == 790)
                {
                    colorName = "Paper Heart";
                    orderCreated = true;
                    red = 250;
                    green = 218;
                    blue = 209;
                }
            else if (count == 791)
                {
                    colorName = "Artist's Canvas";
                    orderCreated = true;
                    red = 238;
                    green = 227;
                    blue = 212;
                }
            else if (count == 792)
                {
                    colorName = "Sweetheart";
                    orderCreated = true;
                    red = 247;
                    green = 194;
                    blue = 237;
                }
            else if (count == 793)
                {
                    colorName = "White Opal";
                    orderCreated = true;
                    red = 230;
                    green = 226;
                    blue = 222;
                }
            else if (count == 794)
                {
                    colorName = "Water Sprout";
                    orderCreated = true;
                    red = 229;
                    green = 253;
                    blue = 197;
                }
            else if (count == 795)
                {
                    colorName = "Natural Linen";
                    orderCreated = true;
                    red = 236;
                    green = 228;
                    blue = 215;
                }
            else if (count == 796)
                {
                    colorName = "Lovely Lavender";
                    orderCreated = true;
                    red = 219;
                    green = 217;
                    blue = 244;
                }
            else if (count == 797)
                {
                    colorName = "Cabbage Leaf";
                    orderCreated = true;
                    red = 225;
                    green = 248;
                    blue = 207;
                }
            else if (count == 798)
                {
                    colorName = "Pebble Cream";
                    orderCreated = true;
                    red = 245;
                    green = 229;
                    blue = 207;
                }
            else if (count == 799)
                {
                    colorName = "Melting Moment";
                    orderCreated = true;
                    red = 212;
                    green = 244;
                    blue = 225;
                }
            else if (count == 800)
                {
                    colorName = "Malted Milk";
                    orderCreated = true;
                    red = 236;
                    green = 226;
                    blue = 220;
                }
            else if (count == 801)
                {
                    colorName = "May Apple";
                    orderCreated = true;
                    red = 242;
                    green = 244;
                    blue = 196;
                }
            else if (count == 802)
                {
                    colorName = "Pale Sunshine";
                    orderCreated = true;
                    red = 255;
                    green = 240;
                    blue = 188;
                }
            else if (count == 803)
                {
                    colorName = "Kiss Good Night";
                    orderCreated = true;
                    red = 236;
                    green = 198;
                    blue = 249;
                }
            else if (count == 804)
                {
                    colorName = "Spring Bouquet";
                    orderCreated = true;
                    red = 222;
                    green = 217;
                    blue = 244;
                }
            else if (count == 805)
                {
                    colorName = "Venetian Pearl";
                    orderCreated = true;
                    red = 215;
                    green = 255;
                    blue = 214;
                }
            else if (count == 806)
                {
                    colorName = "Cassia Buds";
                    orderCreated = true;
                    red = 230;
                    green = 207;
                    blue = 247;
                }
            else if (count == 807)
                {
                    colorName = "Spun Wool";
                    orderCreated = true;
                    red = 231;
                    green = 230;
                    blue = 223;
                }
            else if (count == 808)
                {
                    colorName = "Garlic Clove";
                    orderCreated = true;
                    red = 247;
                    green = 243;
                    blue = 195;
                }
            else if (count == 809)
                {
                    colorName = "Purple Veil";
                    orderCreated = true;
                    red = 214;
                    green = 224;
                    blue = 247;
                }
            else if (count == 810)
                {
                    colorName = "Meringue";
                    orderCreated = true;
                    red = 254;
                    green = 245;
                    blue = 186;
                }
            else if (count == 811)
                {
                    colorName = "Possibly Pink";
                    orderCreated = true;
                    red = 247;
                    green = 217;
                    blue = 222;
                }
            else if (count == 812)
                {
                    colorName = "Lavender Memory";
                    orderCreated = true;
                    red = 215;
                    green = 221;
                    blue = 250;
                }
            else if (count == 813)
                {
                    colorName = "Frosted Lemon";
                    orderCreated = true;
                    red = 255;
                    green = 239;
                    blue = 193;
                }
            else if (count == 814)
                {
                    colorName = "After Rain";
                    orderCreated = true;
                    red = 199;
                    green = 239;
                    blue = 249;
                }
            else if (count == 815)
                {
                    colorName = "Lilac Mist";
                    orderCreated = true;
                    red = 228;
                    green = 227;
                    blue = 232;
                }
            else if (count == 816)
                {
                    colorName = "Peachtree";
                    orderCreated = true;
                    red = 255;
                    green = 215;
                    blue = 218;
                }
            else if (count == 817)
                {
                    colorName = "Cameo White";
                    orderCreated = true;
                    red = 233;
                    green = 230;
                    blue = 225;
                }
            else if (count == 818)
                {
                    colorName = "Tropical Pool";
                    orderCreated = true;
                    red = 194;
                    green = 244;
                    blue = 251;
                }
            else if (count == 819)
                {
                    colorName = "Garden Fairy";
                    orderCreated = true;
                    red = 210;
                    green = 224;
                    blue = 255;
                }
            else if (count == 820)
                {
                    colorName = "Morning Breeze";
                    orderCreated = true;
                    red = 199;
                    green = 240;
                    blue = 251;
                }
            else if (count == 821)
                {
                    colorName = "Frittata";
                    orderCreated = true;
                    red = 253;
                    green = 238;
                    blue = 199;
                }
            else if (count == 822)
                {
                    colorName = "Fading Fog";
                    orderCreated = true;
                    red = 228;
                    green = 230;
                    blue = 232;
                }
            else if (count == 823)
                {
                    colorName = "Creme Brulee";
                    orderCreated = true;
                    red = 246;
                    green = 238;
                    blue = 207;
                }
            else if (count == 824)
                {
                    colorName = "Mannequin Cream";
                    orderCreated = true;
                    red = 248;
                    green = 232;
                    blue = 211;
                }
            else if (count == 825)
                {
                    colorName = "New Day";
                    orderCreated = true;
                    red = 219;
                    green = 245;
                    blue = 227;
                }
            else if (count == 826)
                {
                    colorName = "Drowsy Lavender";
                    orderCreated = true;
                    red = 218;
                    green = 233;
                    blue = 241;
                }
            else if (count == 827)
                {
                    colorName = "Script White";
                    orderCreated = true;
                    red = 223;
                    green = 232;
                    blue = 237;
                }
            else if (count == 828)
                {
                    colorName = "Heavenly Aromas";
                    orderCreated = true;
                    red = 242;
                    green = 226;
                    blue = 224;
                }
            else if (count == 829)
                {
                    colorName = "Derry Coast Sunrise";
                    orderCreated = true;
                    red = 252;
                    green = 223;
                    blue = 218;
                }
            else if (count == 830)
                {
                    colorName = "Ceylon Cream";
                    orderCreated = true;
                    red = 243;
                    green = 233;
                    blue = 217;
                }
            else if (count == 831)
                {
                    colorName = "Melted Marshmallow";
                    orderCreated = true;
                    red = 255;
                    green = 224;
                    blue = 214;
                }
            else if (count == 832)
                {
                    colorName = "Muffin Mix";
                    orderCreated = true;
                    red = 248;
                    green = 226;
                    blue = 220;
                }
            else if (count == 833)
                {
                    colorName = "Tailwind";
                    orderCreated = true;
                    red = 246;
                    green = 237;
                    blue = 211;
                }
            else if (count == 834)
                {
                    colorName = "Streetwise";
                    orderCreated = true;
                    red = 220;
                    green = 241;
                    blue = 233;
                }
            else if (count == 835)
                {
                    colorName = "Country Dairy";
                    orderCreated = true;
                    red = 242;
                    green = 239;
                    blue = 214;
                }
            else if (count == 836)
                {
                    colorName = "Atlantis Pearl";
                    orderCreated = true;
                    red = 244;
                    green = 237;
                    blue = 214;
                }
            else if (count == 837)
                {
                    colorName = "Misty Lavender";
                    orderCreated = true;
                    red = 224;
                    green = 226;
                    blue = 245;
                }
            else if (count == 838)
                {
                    colorName = "Twinkle";
                    orderCreated = true;
                    red = 251;
                    green = 248;
                    blue = 197;
                }
            else if (count == 839)
                {
                    colorName = "Monologue";
                    orderCreated = true;
                    red = 228;
                    green = 215;
                    blue = 253;
                }
            else if (count == 840)
                {
                    colorName = "Cottage White 1813";
                    orderCreated = true;
                    red = 244;
                    green = 236;
                    blue = 217;
                }
            else if (count == 841)
                {
                    colorName = "Cloud Nine";
                    orderCreated = true;
                    red = 235;
                    green = 229;
                    blue = 233;
                }
            else if (count == 842)
                {
                    colorName = "Lotus Petal";
                    orderCreated = true;
                    red = 248;
                    green = 211;
                    blue = 238;
                }
            else if (count == 843)
                {
                    colorName = "Morning Sunlight";
                    orderCreated = true;
                    red = 253;
                    green = 243;
                    blue = 202;
                }
            else if (count == 844)
                {
                    colorName = "Shoelace";
                    orderCreated = true;
                    red = 236;
                    green = 236;
                    blue = 226;
                }
            else if (count == 845)
                {
                    colorName = "Clear Yellow";
                    orderCreated = true;
                    red = 246;
                    green = 242;
                    blue = 211;
                }
            else if (count == 846)
                {
                    colorName = "Shimmering Pool";
                    orderCreated = true;
                    red = 213;
                    green = 255;
                    blue = 231;
                }
            else if (count == 847)
                {
                    colorName = "Honeysuckle White";
                    orderCreated = true;
                    red = 248;
                    green = 240;
                    blue = 212;
                }
            else if (count == 848)
                {
                    colorName = "Parchment Paper";
                    orderCreated = true;
                    red = 242;
                    green = 237;
                    blue = 221;
                }
            else if (count == 849)
                {
                    colorName = "Almond Milk";
                    orderCreated = true;
                    red = 249;
                    green = 236;
                    blue = 215;
                }
            else if (count == 850)
                {
                    colorName = "Prelude To Pink";
                    orderCreated = true;
                    red = 237;
                    green = 229;
                    blue = 234;
                }
            else if (count == 851)
                {
                    colorName = "Cottage White";
                    orderCreated = true;
                    red = 245;
                    green = 238;
                    blue = 218;
                }
            else if (count == 852)
                {
                    colorName = "Moon Mist";
                    orderCreated = true;
                    red = 252;
                    green = 247;
                    blue = 202;
                }
            else if (count == 853)
                {
                    colorName = "Canyon Wind";
                    orderCreated = true;
                    red = 230;
                    green = 240;
                    blue = 231;
                }
            else if (count == 854)
                {
                    colorName = "Heavy Cream";
                    orderCreated = true;
                    red = 245;
                    green = 235;
                    blue = 221;
                }
            else if (count == 855)
                {
                    colorName = "Spearmint Stick";
                    orderCreated = true;
                    red = 227;
                    green = 252;
                    blue = 223;
                }
            else if (count == 856)
                {
                    colorName = "Summer Crush";
                    orderCreated = true;
                    red = 248;
                    green = 212;
                    blue = 242;
                }
            else if (count == 857)
                {
                    colorName = "Wine Pairing";
                    orderCreated = true;
                    red = 238;
                    green = 222;
                    blue = 242;
                }
            else if (count == 858)
                {
                    colorName = "Sapphireberry";
                    orderCreated = true;
                    red = 203;
                    green = 251;
                    blue = 249;
                }
            else if (count == 859)
                {
                    colorName = "Cave Pearl";
                    orderCreated = true;
                    red = 240;
                    green = 231;
                    blue = 232;
                }
            else if (count == 860)
                {
                    colorName = "Opal Cream";
                    orderCreated = true;
                    red = 254;
                    green = 242;
                    blue = 208;
                }
            else if (count == 861)
                {
                    colorName = "Vanilla Frost";
                    orderCreated = true;
                    red = 245;
                    green = 237;
                    blue = 222;
                }
            else if (count == 862)
                {
                    colorName = "Linen White 1870";
                    orderCreated = true;
                    red = 247;
                    green = 238;
                    blue = 220;
                }
            else if (count == 863)
                {
                    colorName = "Marquee White";
                    orderCreated = true;
                    red = 247;
                    green = 238;
                    blue = 220;
                }
            else if (count == 864)
                {
                    colorName = "Cool Cream";
                    orderCreated = true;
                    red = 253;
                    green = 225;
                    blue = 228;
                }
            else if (count == 865)
                {
                    colorName = "Spring White";
                    orderCreated = true;
                    red = 237;
                    green = 245;
                    blue = 224;
                }
            else if (count == 866)
                {
                    colorName = "Bleached Linen";
                    orderCreated = true;
                    red = 243;
                    green = 236;
                    blue = 227;
                }
            else if (count == 867)
                {
                    colorName = "Southern Beauty";
                    orderCreated = true;
                    red = 251;
                    green = 218;
                    blue = 238;
                }
            else if (count == 868)
                {
                    colorName = "Ice Sculpture";
                    orderCreated = true;
                    red = 227;
                    green = 242;
                    blue = 238;
                }
            else if (count == 869)
                {
                    colorName = "Effervescent";
                    orderCreated = true;
                    red = 251;
                    green = 249;
                    blue = 207;
                }
            else if (count == 870)
                {
                    colorName = "Patient White";
                    orderCreated = true;
                    red = 242;
                    green = 229;
                    blue = 237;
                }
            else if (count == 871)
                {
                    colorName = "Winter Ice";
                    orderCreated = true;
                    red = 223;
                    green = 233;
                    blue = 252;
                }
            else if (count == 872)
                {
                    colorName = "Twinkled Pink";
                    orderCreated = true;
                    red = 238;
                    green = 221;
                    blue = 249;
                }
            else if (count == 873)
                {
                    colorName = "Cosmic Dust";
                    orderCreated = true;
                    red = 248;
                    green = 246;
                    blue = 215;
                }
            else if (count == 874)
                {
                    colorName = "Calm";
                    orderCreated = true;
                    red = 225;
                    green = 246;
                    blue = 238;
                }
            else if (count == 875)
                {
                    colorName = "Lychee";
                    orderCreated = true;
                    red = 241;
                    green = 247;
                    blue = 221;
                }
            else if (count == 876)
                {
                    colorName = "Milkyway Galaxy";
                    orderCreated = true;
                    red = 249;
                    green = 245;
                    blue = 216;
                }
            else if (count == 877)
                {
                    colorName = "Rain Water";
                    orderCreated = true;
                    red = 218;
                    green = 245;
                    blue = 247;
                }
            else if (count == 878)
                {
                    colorName = "Tailors Chalk";
                    orderCreated = true;
                    red = 240;
                    green = 236;
                    blue = 234;
                }
            else if (count == 879)
                {
                    colorName = "Soft Pink";
                    orderCreated = true;
                    red = 253;
                    green = 226;
                    blue = 232;
                }
            else if (count == 880)
                {
                    colorName = "Mist Yellow";
                    orderCreated = true;
                    red = 250;
                    green = 243;
                    blue = 218;
                }
            else if (count == 881)
                {
                    colorName = "Linen White";
                    orderCreated = true;
                    red = 249;
                    green = 240;
                    blue = 222;
                }
            else if (count == 882)
                {
                    colorName = "At Ease";
                    orderCreated = true;
                    red = 233;
                    green = 250;
                    blue = 228;
                }
            else if (count == 883)
                {
                    colorName = "Snowdrop";
                    orderCreated = true;
                    red = 215;
                    green = 250;
                    blue = 247;
                }
            else if (count == 884)
                {
                    colorName = "Sea Ice";
                    orderCreated = true;
                    red = 218;
                    green = 255;
                    blue = 239;
                }
            else if (count == 885)
                {
                    colorName = "Reverie Pink";
                    orderCreated = true;
                    red = 245;
                    green = 231;
                    blue = 237;
                }
            else if (count == 886)
                {
                    colorName = "Mineral Water";
                    orderCreated = true;
                    red = 213;
                    green = 252;
                    blue = 248;
                }
            else if (count == 887)
                {
                    colorName = "White Lavender";
                    orderCreated = true;
                    red = 229;
                    green = 233;
                    blue = 251;
                }
            else if (count == 888)
                {
                    colorName = "Cotton Tail";
                    orderCreated = true;
                    red = 253;
                    green = 240;
                    blue = 221;
                }
            else if (count == 889)
                {
                    colorName = "Blowing Kisses";
                    orderCreated = true;
                    red = 251;
                    green = 219;
                    blue = 244;
                }
            else if (count == 890)
                {
                    colorName = "Strawberry Yogurt";
                    orderCreated = true;
                    red = 250;
                    green = 225;
                    blue = 240;
                }
            else if (count == 891)
                {
                    colorName = "Glass Bead";
                    orderCreated = true;
                    red = 226;
                    green = 242;
                    blue = 247;
                }
            else if (count == 892)
                {
                    colorName = "Vaguely Violet";
                    orderCreated = true;
                    red = 224;
                    green = 236;
                    blue = 255;
                }
            else if (count == 893)
                {
                    colorName = "Sun Glint";
                    orderCreated = true;
                    red = 251;
                    green = 249;
                    blue = 216;
                }
            else if (count == 894)
                {
                    colorName = "Innocence";
                    orderCreated = true;
                    red = 251;
                    green = 242;
                    blue = 223;
                }
            else if (count == 895)
                {
                    colorName = "Bubble Bath";
                    orderCreated = true;
                    red = 237;
                    green = 228;
                    blue = 252;
                }
            else if (count == 896)
                {
                    colorName = "White 1852";
                    orderCreated = true;
                    red = 238;
                    green = 242;
                    blue = 238;
                }
            else if (count == 897)
                {
                    colorName = "Glacier Bay";
                    orderCreated = true;
                    red = 222;
                    green = 255;
                    blue = 241;
                }
            else if (count == 898)
                {
                    colorName = "Petal Dust";
                    orderCreated = true;
                    red = 242;
                    green = 227;
                    blue = 249;
                }
            else if (count == 899)
                {
                    colorName = "Blissful";
                    orderCreated = true;
                    red = 234;
                    green = 229;
                    blue = 255;
                }
            else if (count == 900)
                {
                    colorName = "Aegean Mist";
                    orderCreated = true;
                    red = 234;
                    green = 249;
                    blue = 236;
                }
            else if (count == 901)
                {
                    colorName = "Pearl Drops";
                    orderCreated = true;
                    red = 242;
                    green = 240;
                    blue = 237;
                }
            else if (count == 902)
                {
                    colorName = "White Bl-w14";
                    orderCreated = true;
                    red = 238;
                    green = 243;
                    blue = 238;
                }
            else if (count == 903)
                {
                    colorName = "Swirling Water";
                    orderCreated = true;
                    red = 233;
                    green = 243;
                    blue = 243;
                }
            else if (count == 904)
                {
                    colorName = "Genteel Lavender";
                    orderCreated = true;
                    red = 230;
                    green = 240;
                    blue = 250;
                }
            else if (count == 905)
                {
                    colorName = "Pink Proposal";
                    orderCreated = true;
                    red = 246;
                    green = 222;
                    blue = 252;
                }
            else if (count == 906)
                {
                    colorName = "Frolic";
                    orderCreated = true;
                    red = 251;
                    green = 231;
                    blue = 239;
                }
            else if (count == 907)
                {
                    colorName = "Morning Haze";
                    orderCreated = true;
                    red = 228;
                    green = 243;
                    blue = 250;
                }
            else if (count == 908)
                {
                    colorName = "White Hydrangea";
                    orderCreated = true;
                    red = 250;
                    green = 252;
                    blue = 219;
                }
            else if (count == 909)
                {
                    colorName = "Powder Sand";
                    orderCreated = true;
                    red = 250;
                    green = 246;
                    blue = 226;
                }
            else if (count == 910)
                {
                    colorName = "White Sapphire";
                    orderCreated = true;
                    red = 230;
                    green = 249;
                    blue = 243;
                }
            else if (count == 911)
                {
                    colorName = "Bit Of Lime";
                    orderCreated = true;
                    red = 249;
                    green = 249;
                    blue = 224;
                }
            else if (count == 912)
                {
                    colorName = "Fine White";
                    orderCreated = true;
                    red = 251;
                    green = 239;
                    blue = 233;
                }
            else if (count == 913)
                {
                    colorName = "Hush Pink";
                    orderCreated = true;
                    red = 251;
                    green = 233;
                    blue = 240;
                }
            else if (count == 914)
                {
                    colorName = "Soar";
                    orderCreated = true;
                    red = 223;
                    green = 255;
                    blue = 246;
                }
            else if (count == 915)
                {
                    colorName = "Glass Of Milk";
                    orderCreated = true;
                    red = 253;
                    green = 247;
                    blue = 224;
                }
            else if (count == 916)
                {
                    colorName = "Whisper White";
                    orderCreated = true;
                    red = 245;
                    green = 243;
                    blue = 237;
                }
            else if (count == 917)
                {
                    colorName = "Silver Chalice";
                    orderCreated = true;
                    red = 238;
                    green = 241;
                    blue = 247;
                }
            else if (count == 918)
                {
                    colorName = "Coconut Twist";
                    orderCreated = true;
                    red = 249;
                    green = 246;
                    blue = 231;
                }
            else if (count == 919)
                {
                    colorName = "Himalayan Mist";
                    orderCreated = true;
                    red = 228;
                    green = 255;
                    blue = 244;
                }
            else if (count == 920)
                {
                    colorName = "New House White";
                    orderCreated = true;
                    red = 244;
                    green = 243;
                    blue = 240;
                }
            else if (count == 921)
                {
                    colorName = "Zephyr";
                    orderCreated = true;
                    red = 249;
                    green = 226;
                    blue = 253;
                }
            else if (count == 922)
                {
                    colorName = "Soft Lace";
                    orderCreated = true;
                    red = 248;
                    green = 241;
                    blue = 239;
                }
            else if (count == 923)
                {
                    colorName = "Cascade White";
                    orderCreated = true;
                    red = 237;
                    green = 249;
                    blue = 243;
                }
            else if (count == 924)
                {
                    colorName = "Simply White";
                    orderCreated = true;
                    red = 249;
                    green = 245;
                    blue = 236;
                }
            else if (count == 925)
                {
                    colorName = "Bermuda Shell";
                    orderCreated = true;
                    red = 252;
                    green = 242;
                    blue = 237;
                }
            else if (count == 926)
                {
                    colorName = "Swan Wing";
                    orderCreated = true;
                    red = 247;
                    green = 246;
                    blue = 238;
                }
            else if (count == 927)
                {
                    colorName = "Sweet Roses";
                    orderCreated = true;
                    red = 246;
                    green = 239;
                    blue = 247;
                }
            else if (count == 928)
                {
                    colorName = "Frosted Juniper";
                    orderCreated = true;
                    red = 241;
                    green = 251;
                    blue = 241;
                }
            else if (count == 929)
                {
                    colorName = "Frost";
                    orderCreated = true;
                    red = 242;
                    green = 247;
                    blue = 245;
                }
            else if (count == 930)
                {
                    colorName = "Popped Corn";
                    orderCreated = true;
                    red = 246;
                    green = 248;
                    blue = 242;
                }
            else if (count == 931)
                {
                    colorName = "First Blush";
                    orderCreated = true;
                    red = 248;
                    green = 239;
                    blue = 250;
                }
            else if (count == 932)
                {
                    colorName = "Windmill Wings";
                    orderCreated = true;
                    red = 242;
                    green = 248;
                    blue = 248;
                }
            else if (count == 933)
                {
                    colorName = "Powdered Snow";
                    orderCreated = true;
                    red = 251;
                    green = 249;
                    blue = 239;
                }
            else if (count == 934)
                {
                    colorName = "Ultra Pure White1";
                    orderCreated = true;
                    red = 248;
                    green = 248;
                    blue = 244;
                }
            else if (count == 935)
                {
                    colorName = "Shea";
                    orderCreated = true;
                    red = 252;
                    green = 245;
                    blue = 244;
                }
            else if (count == 936)
                {
                    colorName = "Smart White";
                    orderCreated = true;
                    red = 249;
                    green = 248;
                    blue = 247;
                }
            else if (count == 937)
                {
                    colorName = "Ultra Pure White2";
                    orderCreated = true;
                    red = 250;
                    green = 253;
                    blue = 247;
                }
                getOrder();







                }
}