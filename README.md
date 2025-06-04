# 🧾 AuctionPortal - ASP.NET MVC Auction Catalogue Viewer

## 📌 Overview

**AuctionPortal** is a web application built with **ASP.NET MVC**, **Razor View Engine**, and the **WebMatrix.Data** library to display and manage auction catalogues and lots. The project connects to a SQL Server database and allows users to:

- View available auction catalogues
- Filter catalogues by auction type and date
- Browse lots within a selected catalogue
- View detailed information for each lot

## ⚙️ Technologies Used

- ASP.NET MVC (Framework 4.8)
- Razor (.cshtml)
- WebMatrix.Data (for SQL access)
- SQL Server (local or remote)
- Bootstrap 5.2 (for responsive UI)

## 📁 Project Structure

/Controllers <br/>
└── HomeController.cs <br/>
/Views <br/>
└── Home <br/>
├── Index.cshtml # Display auction catalogues <br/>
├── Catalogue.cshtml # Display lots for a catalogue <br/>
└── Lot.cshtml # Display detailed info for a lot <br/>
└── Shared <br/>
└── _Layout.cshtml # Main layout (includes Bootstrap styling) <br/>
/App_Start <br/>
└── RouteConfig.cs # MVC routing <br/>
/Web.config # Connection string and config <br/>

## 🔗 Database Connection

Edit `Web.config` to match your local SQL Server setup:

```xml
<connectionStrings>
  <add name="AuctionDB"
       connectionString="Data Source=LAPTOP-936\\DDM1;Initial Catalog=AuctionDB;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```
💡 Features
📦 Catalogue List: Shows upcoming and past auctions

🔍 Search/Filter: By auction type and/or date

🎯 Lot Browsing: Each catalogue links to its available lots

🖼 Lot Details: Includes price, bidder info, multiple images

🧪 HTML Validation: Follows semantic and accessible markup

🚀 How to Run
Open the solution in Visual Studio.

Make sure SQL Server is running and the AuctionDB is created using the provided SQL script.

Update Web.config connection string.

Build and run the project (F5).

📚 Credits
Bootstrap 5.2: https://getbootstrap.com/

Microsoft WebMatrix: https://learn.microsoft.com/en-us/aspnet/web-pages/overview/data/

📄 License
This project is for educational purposes only. All content and code must be your own work.