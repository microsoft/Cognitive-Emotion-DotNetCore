using System;
using Microsoft.ProjectOxford.Emotion;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Emotion.Contract;

namespace EmotionServiceClientSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            try
            {
                Console.WriteLine("Enter your Cognitive Services Emotion API Key:");
                var apiKey = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter the url of the image you want to detect emotion in:");
                var imageUrl = Console.ReadLine();
                Console.WriteLine();

                DetectEmotion(apiKey, imageUrl).Wait();
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        private static async Task DetectEmotion(string apiKey, string imageUrl)
        {
            var emotionServiceClient = new EmotionServiceClient(apiKey);
            Emotion[] emotionResult = await emotionServiceClient.RecognizeAsync(imageUrl);
            LogEmotionResult(emotionResult);
        }

        #region Helpers

        private static void Log(string message)
        {
            Console.WriteLine(message);
        }

        private static void LogEmotionResult(Emotion[] emotionResult)
        {
            int emotionResultCount = 0;
            if (emotionResult != null && emotionResult.Length > 0)
            {
                foreach (Emotion emotion in emotionResult)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Log("Face[" + emotionResultCount + "]");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Log("  FaceRectangle");
                    Log("    Left   :" + emotion.FaceRectangle.Left);
                    Log("    Top    :" + emotion.FaceRectangle.Top);
                    Log("    Width  :" + emotion.FaceRectangle.Width);
                    Log("    Height :" + emotion.FaceRectangle.Height);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Log("  Emotions");
                    Log("    Anger    : " + emotion.Scores.Anger.ToString());
                    Log("    Contempt : " + emotion.Scores.Contempt.ToString());
                    Log("    Disgust  : " + emotion.Scores.Disgust.ToString());
                    Log("    Fear     : " + emotion.Scores.Fear.ToString());
                    Log("    Happiness: " + emotion.Scores.Happiness.ToString());
                    Log("    Neutral  : " + emotion.Scores.Neutral.ToString());
                    Log("    Sadness  : " + emotion.Scores.Sadness.ToString());
                    Log("    Surprise  : " + emotion.Scores.Surprise.ToString());

                    Log("");

                    emotionResultCount++;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Log("No emotion is detected. This might be due to:\n" +
                    "    image is too small to detect faces\n" +
                    "    no faces are in the images\n" +
                    "    faces poses make it difficult to detect emotions\n" +
                    "    or other factors");
            }
        }

        #endregion Helpers
    }
}