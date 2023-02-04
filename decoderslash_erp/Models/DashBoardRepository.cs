﻿namespace decoderslash_erp.Models
{
    public class DashBoardRepository
    {
        public static List<CardSectionModel> MakeSectionsList()
        {
            List<CardModelLeft> cards = new List<CardModelLeft>();
            cards.Add(new CardModelLeft
            {
                Counter = 278,
                Tag = "Add New User",
                Icon = "icon-pencil primary",
                Types = "Left",
                Controller = "SignUp",
                Action = "Index"
            });

            cards.Add(new CardModelLeft
            {
                Counter = 156,
                Tag = "New Clients",
                Icon = "icon-user success",
                Types = "Right",
                Controller = "#",
                Action = "#"
            });

            cards.Add(new CardModelLeft
            {
                Counter = 278,
                Tag = "New Posts",
                Icon = "icon-book-open primary",
                Controller = "#",
                Types = "Progress",
                Volume = "10",
                Action = "#"
            });

            List<CardModelLeft> cards1 = new List<CardModelLeft>();
            cards1.Add(new CardModelLeft
            {
                Counter = 278,
                Tag = "Another Row of cards",
                Icon = "icon-pencil primary",
                Types = "Left",
                Controller = "SignUp",
                Action = "Index"
            });

            cards1.Add(new CardModelLeft
            {
                Counter = 156,
                Tag = "New Row",
                Icon = "icon-user success",
                Types = "Right",
                Controller = "#",
                Action = "#"
            });


            List<List<CardModelLeft>> data = new List<List<CardModelLeft>>();
            data.Add(cards);
            data.Add(cards1);

            CardSectionModel cardSection = new CardSectionModel()
            {
                Head = "Site Controls",
                Tag = "Admins Love Controlling Systems :)",
                Rows = 1,
                Data = data
            };

            List<CardModelLeft> cards2 = new List<CardModelLeft>();
            cards2.Add(new CardModelLeft
            {
                Counter = 278,
                Tag = "Add New User",
                Icon = "icon-pencil primary",
                Types = "Left",
                Controller = "SignUp",
                Action = "Index"
            });

            cards2.Add(new CardModelLeft
            {
                Counter = 156,
                Tag = "New Clients",
                Icon = "icon-user success",
                Types = "Right",
                Controller = "#",
                Action = "#"
            });

            List<CardModelLeft> cards3 = new List<CardModelLeft>();
            cards3.Add(new CardModelLeft
            {
                Counter = 278,
                Tag = "Another Row of cards",
                Icon = "icon-pencil primary",
                Types = "Left",
                Controller = "SignUp",
                Action = "Index"
            });

            List<List<CardModelLeft>> data1 = new List<List<CardModelLeft>>();
            data1.Add(cards2);
            data1.Add(cards3);

            CardSectionModel cardSection1 = new CardSectionModel()
            {
                Head = "Second Section Testing",
                Tag = "This design is tricking my mind ;)",
                Rows = 1,
                Data = data1
            };


            List<CardSectionModel> cardsectionlist = new List<CardSectionModel>();
            cardsectionlist.Add(cardSection);
            cardsectionlist.Add(cardSection1);

            return cardsectionlist;
        } 
    }
}