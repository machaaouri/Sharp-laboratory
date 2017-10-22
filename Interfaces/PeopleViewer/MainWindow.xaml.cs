﻿using PersonRepository.CSV;
using PersonRepository.Interface;
using PersonRepository.Service;
using PersonRepository.SQL;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ServiceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            IPersonRepository repository =  new ServiceRepository();
            var peopel = repository.GetPeople();
            foreach (var person in peopel)
                PersonListBox.Items.Add(person);

            ShowRepositoryType(repository);
        }

        private void CSVFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            IPersonRepository repository = new CSVRepository();
            var peopel = repository.GetPeople();
            foreach (var person in peopel)
                PersonListBox.Items.Add(person);

            ShowRepositoryType(repository);

        }

        private void SQLFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            IPersonRepository repository = new SQLRepository();
            var peopel = repository.GetPeople();
            foreach (var person in peopel)
                PersonListBox.Items.Add(person);

            ShowRepositoryType(repository);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            MessageBox.Show(string.Format("Repository Type:\n{0}",
                repository.GetType().ToString()));
        }
    }
}
