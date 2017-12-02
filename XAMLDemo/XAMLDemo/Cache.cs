using AppServiceHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XAMLDemo
{
    public class Cache : EntityData
    {
        private string _title;
        private readonly string _textMessage;
        private readonly bool _visibility;
        /*
        private string _author;
        private readonly Coordinate _coordinate;
        private int _range;
        private List<string> _tags;
        private readonly DateTime _dateTimeStamp;
        */

        public Cache(string textMessage, bool visibility/*, Coordinate coordinate, int Range, DateTime dateTimeStamp*/)
            : this("Unknown", textMessage, visibility/*, "Unknown", coordinate, range, List<sting>(), dateTimeStamp*/) { }

        public Cache(string title, string textMessage, bool visibility/*, string author, Coordinate coordinate, 
                     int range, List<string> tags, DateTime dateTimeStamp*/)
        {
            Title = title;
            _textMessage = textMessage;
            _visibility = visibility;
            /*
            string Author = author;
            _coordinate = coordinate;
            Range = range;
            Tags = tags;
            _dateTimeStamp = dateTimeStamp;
            */
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string TextMessage
        {
            get { return _textMessage; }
        }

        public bool Visability
        {
            get { return _visibility; }
        }

        /*
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        
        public Coordinate Coordinate
        {
            get { return _coordinate; }
        }

        public int Range
        {
            get { return _range; }
            set { _range = value; }
        }

        // Test the setting with non list<string> var
        public List<string> Tags
        {
            get { return _tags; }
            set { _tags = new List<string>(value); }
        }

        public DateTime DateTimeStamp
        {
            get { return _dateTimeStamp; }
        }
        */
    }
}
