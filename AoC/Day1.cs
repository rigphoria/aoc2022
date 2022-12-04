namespace AoC;
using System.IO;

public class Day1{
	public void Solve(){
		int calorieCounter = 0;
		int highestCalories = 0;
		string[] input_lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "day1_input.txt"));

		for (int i = 0; i < input_lines.Length; i++) {
			if(String.IsNullOrWhiteSpace(input_lines[i])){
				if (calorieCounter > highestCalories) {
					highestCalories = calorieCounter;
					calorieCounter = 0;
					continue;
				}
				calorieCounter = 0;
				continue;
			}
			calorieCounter += Int32.Parse(input_lines[i]);
		}
		Console.Write("day 1: " + highestCalories);
	}
}