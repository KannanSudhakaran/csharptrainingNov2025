

using System;

class Program {

    static void Main() {

        //CaseStudy1();
        CaseStudy2();
    
    }

    static void CaseStudy2()
    {
        int[] manyScores = { 100,200,300};
        Console.WriteLine(manyScores.GetHashCode());
        UpdateManyScorestoZero(manyScores);

        foreach (int score in manyScores) {
            Console.WriteLine(score);
        }
    }

    static void UpdateManyScorestoZero(int[] scores) {
        Console.WriteLine(scores.GetHashCode());

        for (int index = 0; index < scores.Length; index++) { 
        
            scores[index] = 0;
        }

    }
    static void CaseStudy1()
    {

        int score = 100;
        UpdateScoreToZero(score);
        Console.WriteLine("current value of score is "+score);
       
    }

    static void UpdateScoreToZero(int inputScore) {
        inputScore = 0;
    }
}