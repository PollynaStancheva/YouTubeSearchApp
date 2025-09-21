# YouTube Search App

A simple C# console application that searches YouTube videos using the **YouTube Data API v3**.  
This project was developed as part of a university exercise.

## 📌 Task Description
The goal of the assignment was to:
1. Test YouTube API requests in **Postman** and explore the JSON response.  
2. Implement a **C# .NET console application** that:
   - Prompts the user for a search query,
   - Sends the query to the YouTube Data API v3,
   - Parses the JSON response,
   - Displays the video titles and links in the console.  
3. Use **model classes** for JSON deserialization (`YouTubeSearchApp.cs`, `Item`, `Snippet`, etc.).

---

## 🚀 Features
- Search YouTube videos by keyword.  
- Display video titles and direct YouTube links.  
- Uses `HttpClient` for requests and `Newtonsoft.Json` for JSON parsing.  

---

## ⚙️ Requirements
- .NET 8.0 SDK  
- Visual Studio (or any C# IDE)  
- A valid **YouTube Data API v3 key** from [Google Cloud Console](https://console.cloud.google.com/)  

---

## ▶️ How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/PollynaStancheva/YouTubeSearchApp.git
   cd YouTubeSearchApp
