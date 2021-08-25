﻿using MailKit;
using SaintSender.Core.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SaintSender.DesktopUI.ViewModels
{
    class InboxViewModel : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Email> _emails;

        public string test { get; set; }

        public ObservableCollection<Email> Emails
        {
            get => _emails;
            set
            {
                _emails = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Emails)));
            }
        }

        public InboxViewModel()
        {
            this.test = "kiskutya";
            Emails = new ObservableCollection<Email>();

            IMailFolder inbox = Authentication.GetInbox();

            this.Emails.Add(new Email("stuff"));
        }
    }
}
