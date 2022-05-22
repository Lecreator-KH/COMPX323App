import java.io.BufferedReader;
import java.io.Console;
import java.io.FileReader;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.*;
import java.util.concurrent.CountDownLatch;
public class Generator{

    public static void main(String args[]){

        Generator g = new Generator();
        g.start();
    }

    ArrayList<String> letters = new ArrayList<String>();
    List<String> players = new ArrayList<>();

    public void populateLetters(){

        for(int i=97;i<123;i++){

            letters.add(String.valueOf((char)i));

        }

        //System.out.println(letters.get(0)+letters.get(25));
    }

    public int getRandomNumber(int min, int max) {

      return (int) ((Math.random() * (max - min)) + min);

    }
    public int eventStart=0;
    public void start(){

        populateLetters();
        // getPerson();
        // System.out.println(getLocation());
        //to run this you need to uncomment the wanted section.
        //when running java Generator > team.txt for example when you want to generate the correct thing
        
        //people
        // for(int i=0; i<100000; i++){

        //     int fLength=getRandomNumber(5 , 10);
        //     int lLength=getRandomNumber(5 , 10);
        //     String fName=genWord(fLength);
        //     String lName=genWord(lLength);
        //     String email=genEmail(fName, lName);
        //     String userName=genUsername(fName, lName,i);
        //     String password=genPassword(genWord(7) , genWord(8) ,i*2);
        //     System.out.println(fName+","+lName+","+email+","+userName+","+password);

        // }
        //events
         for(int i=0; i<100000; i++){
            int wordLength=getRandomNumber(3 , 15);
            int desLength=getRandomNumber(3 , 15);
            String mainSponsor=genWord(wordLength);
            String description =genWord(desLength);
            String date = genDate();
            String startTime=genStartTime();
            String endTime=genEndTime(eventStart);
            String location=getLocation();
            String organizer=getOrganizer();
             System.out.println(date+","+startTime+","+location+","+endTime+","+organizer+","+mainSponsor+","+description);
         }
         
        //teams
        // for(int i=0; i<1000; i++){
        //     int teamNameLength=getRandomNumber(6 , 15);
        //     String teamName=genWord(teamNameLength);
        //     String teamName2=genWord(teamNameLength+1);
        //     String teamEmail=genEmail(teamName, teamName2);
        //     String managerPH=genPh();
        //     String website="www."+teamName+".com";
        //     String sportName=getSport();
        //     System.out.println(teamName+","+teamEmail+","+managerPH+","+website+","+sportName);
        // }

        //Sport
        // for(int i = 0; i < 100; i++) {
        //     int sportLength=getRandomNumber(6 , 16);
        //     String sportName=genWord(sportLength);
        //     int minPlayer=getRandomNumber(1, 11);
        //     int maxPlayer=getRandomNumber(minPlayer, 21);
        //     int subs=getRandomNumber(1, 10);
        //     String setting=getSetting();
        //     System.out.println(sportName+","+minPlayer+","+maxPlayer+","+subs+","+setting);
        // }
        
        //players
        // for(int i = 0; i < 11000; i++) {
        //     int index = getRandomNumber(0, players.size()-1);
        //     String player = players.get(index);
        //     int team = getRandomNumber(1, 1001);
        //     System.out.println(player+","+team);
        //     players.remove(index);
        // }

        // organizer
        // for(int i = 0; i < 100; i++) {
        //     int index = getRandomNumber(0, players.size()-1);
        //     String player = players.get(index);
        //     String organization = genWord(getRandomNumber(1, 50));
        //     String PH=genPh();
        //     System.out.println(player+","+organization+","+PH);
        //     players.remove(index);
        // }
        // Venue
        // for(int i = 0; i < 200; i++) {
        //     String venue = genWord(getRandomNumber(10, 20));
        //     System.out.println(venue);
        // }
    }

    public String getSport() {
        
        List<String> content = new ArrayList<>();
        String file = "sport.csv";
        try(BufferedReader br = new BufferedReader(new FileReader(file))) {
            String line = "";
            while ((line = br.readLine()) != null) {
                // System.out.println(line);
                String[] x = line.split(",");
                // System.out.println(x[0]);
                content.add(x[0]);
            }
        } catch (Exception e) {
          //Some error logging
        }
        // for (String string : content) {
            // System.out.println(string);
        // }
        // System.out.println(content.size());
        int index = getRandomNumber(0,content.size());
        
        return content.get(index);
    }

    public String getLocation() {
        
        List<String> content = new ArrayList<>();
        String file = "venue.csv";
        int counter = 0;
        try(BufferedReader br = new BufferedReader(new FileReader(file))) {
            String line = "";
            while ((line = br.readLine()) != null) {
                // System.out.println(line);
                if(counter%2==0)
                {
                    content.add(line);
                }
                counter++;
            }
        } catch (Exception e) {
          //Some error logging
        }
        content.remove(content.size()-1);
        // for (String string : content) {
        //     System.out.println(string);
        // }
        // System.out.println(content.size());
        int index = getRandomNumber(0,content.size());
        
        return content.get(index);
    }

    public String getOrganizer() {
        
        List<String> content = new ArrayList<>();
        String file = "organizer.csv";
        try(BufferedReader br = new BufferedReader(new FileReader(file))) {
            String line = "";
            while ((line = br.readLine()) != null) {
                // System.out.println(line);
                String[] x = line.split(",");
                // System.out.println(x[0]);
                content.add(x[0]);
            }
        } catch (Exception e) {
          //Some error logging
        }
        // for (String string : content) {
            // System.out.println(string);
        // }
        // System.out.println(content.size());
        int index = getRandomNumber(0,content.size());
        
        return content.get(index);
    }

    public void getPerson() {
        String file = "person.csv";
        try(BufferedReader br = new BufferedReader(new FileReader(file))) {
            String line = "";
            while ((line = br.readLine()) != null) {
                // System.out.println(line);
                String[] x = line.split(",");
                // System.out.println(x[0]);
                players.add(x[0]);
            }
        } catch (Exception e) {
          //Some error logging
        }
        // for (String string : players) {
        //     System.out.println(string);
        // }
        // System.out.println(players.size());
        return;
    }

    public String getSetting() {
        int x = getRandomNumber(0,2);
        // System.out.println(x);
        if(x == 1) {
            return "Outdoor";
        }
        return "Indoor";
    }

    public String genPh(){
        String toReturn="";
        for(int i=0; i<10;i++){
            toReturn+=String.valueOf(getRandomNumber(0,9));
        }
        return toReturn;
    }
      public String genEndTime(int a){

          int q=getRandomNumber(10,59);
          int length=getRandomNumber(1,5);
          return String.valueOf(a+length)+":"+String.valueOf(q);
      }
    public String genStartTime(){
        int s=getRandomNumber(0,18);
        int q=getRandomNumber(10,59);
        eventStart=s;
         String toReturn="";
        if(s<10){
            toReturn= "0"+String.valueOf(s)+":"+String.valueOf(q);
        }
        else{
            toReturn= String.valueOf(s)+":"+String.valueOf(q);
        }

        return toReturn;
    }
    public String genDate(){
        String day= String.valueOf(getRandomNumber(1 , 29));
        String month =String.valueOf(getRandomNumber(1 , 13));
        String year= String.valueOf(getRandomNumber(0 , 22));
        if(Integer.parseInt(year) < 10)
        {
            return day+"/"+month+"/"+"200"+year;
        }
        return day+"/"+month+"/"+"20"+year;
    }

    public String genWord(int length){

        String name="";

        for(int t=0;t<length;t++){

            int position=getRandomNumber(0,25);
            name+=letters.get(position);

        }
        return name;
    }

     public String genEmail(String fname, String lname){

         String email= fname+lname+"@gmail.com";
        
        return email;
    }

    public String genUsername(String fName, String lName,int a){

        String result="";
        for(int b=0; b<4;b++){
            result+=String.valueOf(fName.charAt(b));
        }
        for(int b=0; b<4;b++){
            result+=String.valueOf(lName.charAt(b));
        }
        return result+a;

    }

       public String genPassword(String s1, String s2,int a){

        String result1="";
        
        for(int b=0; b<4;b++){
            result1+=String.valueOf(s1.charAt(b));
        }

        String result2="";

        for(int b=0; b<4;b++){
            result2+=String.valueOf(s2.charAt(b));
        }
        return result1+a+result2;

    }



}