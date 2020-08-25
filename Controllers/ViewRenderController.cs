using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewLecture.Models;
using ViewLecture.ViewModels;

namespace ViewLecture.Controllers
{
    // Sanity check
    public class ViewRenderController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Sanity Test</h1>", "text/html");
        }

        // Display Band Action
        public IActionResult DisplayBand()
        {
            // Inject some content with builtin ViewData
            Band newBand = new Band("RATM","HardcoreFunk");
            ViewData["name"] = newBand.BandName;
            ViewData["genre"] = newBand.BandGenre;
            // Render the view 
            return View();
        }

        // 
        public IActionResult DisplayBand1()
        {
            // Inject some content with builtin ViewData
            Band newBand = new Band("Bad Religion","Punk");

            // Render the view 
            return View(newBand);
        }

        // Render a view passing ion a viewmodel
        public IActionResult TourDates()
        {
            // Create View Model`
            BandTourDates dates = new BandTourDates();
            // Create a band
            dates.Band = new Band("Cheap Trick","Rock");
            // Add dates
            TourDate td = new TourDate("08/25/2020", "Memphis, TN");
            // dates.TourDates.Add(td);
            // return Content($"{dates.TourDates.Count}");

            // return Content($"{td.ShowDate} {td.ShowCity}");
            // return Content($"{dates.Band.BandName} {dates.Band.BandGenre}");

            // dates.TourDates.Add(new TourDate("08/25/2020", "Memphis, TN"));
            // dates.TourDates.Add(new TourDate("01/2/2021", "Paducah, KY"));
            // dates.TourDates.Add(new TourDate("09/25/2021", "Nashville, TN"));

            // // Render the view 
            return View(dates);

        }
    }
}