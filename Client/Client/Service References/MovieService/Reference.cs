﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.MovieService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Genre", Namespace="http://schemas.datacontract.org/2004/07/MoviesService.Models")]
    [System.SerializableAttribute()]
    public partial class Genre : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GenreIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GenreID {
            get {
                return this.GenreIDField;
            }
            set {
                if ((this.GenreIDField.Equals(value) != true)) {
                    this.GenreIDField = value;
                    this.RaisePropertyChanged("GenreID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MoviesService.Models")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.MovieService.Actor[] ActorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CoverURIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DirectorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.MovieService.Genre GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MovieIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.MovieService.Actor[] Actors {
            get {
                return this.ActorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ActorsField, value) != true)) {
                    this.ActorsField = value;
                    this.RaisePropertyChanged("Actors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CoverURI {
            get {
                return this.CoverURIField;
            }
            set {
                if ((object.ReferenceEquals(this.CoverURIField, value) != true)) {
                    this.CoverURIField = value;
                    this.RaisePropertyChanged("CoverURI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DirectorID {
            get {
                return this.DirectorIDField;
            }
            set {
                if ((this.DirectorIDField.Equals(value) != true)) {
                    this.DirectorIDField = value;
                    this.RaisePropertyChanged("DirectorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.MovieService.Genre Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MovieID {
            get {
                return this.MovieIDField;
            }
            set {
                if ((this.MovieIDField.Equals(value) != true)) {
                    this.MovieIDField = value;
                    this.RaisePropertyChanged("MovieID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Actor", Namespace="http://schemas.datacontract.org/2004/07/MoviesService.Models")]
    [System.SerializableAttribute()]
    public partial class Actor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ActorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ExternalActorIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ActorID {
            get {
                return this.ActorIDField;
            }
            set {
                if ((this.ActorIDField.Equals(value) != true)) {
                    this.ActorIDField = value;
                    this.RaisePropertyChanged("ActorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ExternalActorID {
            get {
                return this.ExternalActorIDField;
            }
            set {
                if ((this.ExternalActorIDField.Equals(value) != true)) {
                    this.ExternalActorIDField = value;
                    this.RaisePropertyChanged("ExternalActorID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovieService.IMovieService")]
    public interface IMovieService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetGenres", ReplyAction="http://tempuri.org/IMovieService/GetGenresResponse")]
        Client.MovieService.Genre[] GetGenres();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetGenres", ReplyAction="http://tempuri.org/IMovieService/GetGenresResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Genre[]> GetGenresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMovies", ReplyAction="http://tempuri.org/IMovieService/GetMoviesResponse")]
        Client.MovieService.Movie[] GetMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMovies", ReplyAction="http://tempuri.org/IMovieService/GetMoviesResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByTitle", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByTitleResponse")]
        Client.MovieService.Movie[] GetMoviesByTitle(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByTitle", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByTitleResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByTitleAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByGenre", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByGenreResponse")]
        Client.MovieService.Movie[] GetMoviesByGenre(Client.MovieService.Genre genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByGenre", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByGenreResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByGenreAsync(Client.MovieService.Genre genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByTitlePart", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByTitlePartResponse")]
        Client.MovieService.Movie[] GetMoviesByTitlePart(string part);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByTitlePart", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByTitlePartResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByTitlePartAsync(string part);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByYear", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByYearResponse")]
        Client.MovieService.Movie[] GetMoviesByYear(int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByYear", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByYearResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByYearAsync(int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByDirector", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByDirectorResponse")]
        Client.MovieService.Movie[] GetMoviesByDirector(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByDirector", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByDirectorResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByDirectorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByActor", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByActorResponse")]
        Client.MovieService.Movie[] GetMoviesByActor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/GetMoviesByActor", ReplyAction="http://tempuri.org/IMovieService/GetMoviesByActorResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByActorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/AddMovie", ReplyAction="http://tempuri.org/IMovieService/AddMovieResponse")]
        Client.MovieService.Movie AddMovie(Client.MovieService.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/AddMovie", ReplyAction="http://tempuri.org/IMovieService/AddMovieResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Movie> AddMovieAsync(Client.MovieService.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/AddGenre", ReplyAction="http://tempuri.org/IMovieService/AddGenreResponse")]
        Client.MovieService.Genre AddGenre(Client.MovieService.Genre genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/AddGenre", ReplyAction="http://tempuri.org/IMovieService/AddGenreResponse")]
        System.Threading.Tasks.Task<Client.MovieService.Genre> AddGenreAsync(Client.MovieService.Genre genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/DeleteMovie", ReplyAction="http://tempuri.org/IMovieService/DeleteMovieResponse")]
        void DeleteMovie(Client.MovieService.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/DeleteMovie", ReplyAction="http://tempuri.org/IMovieService/DeleteMovieResponse")]
        System.Threading.Tasks.Task DeleteMovieAsync(Client.MovieService.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/DeleteGenre", ReplyAction="http://tempuri.org/IMovieService/DeleteGenreResponse")]
        void DeleteGenre(Client.MovieService.Genre genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/DeleteGenre", ReplyAction="http://tempuri.org/IMovieService/DeleteGenreResponse")]
        System.Threading.Tasks.Task DeleteGenreAsync(Client.MovieService.Genre genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/UpdateMovie", ReplyAction="http://tempuri.org/IMovieService/UpdateMovieResponse")]
        bool UpdateMovie(Client.MovieService.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/UpdateMovie", ReplyAction="http://tempuri.org/IMovieService/UpdateMovieResponse")]
        System.Threading.Tasks.Task<bool> UpdateMovieAsync(Client.MovieService.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/UpdateGenre", ReplyAction="http://tempuri.org/IMovieService/UpdateGenreResponse")]
        bool UpdateGenre(Client.MovieService.Genre genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovieService/UpdateGenre", ReplyAction="http://tempuri.org/IMovieService/UpdateGenreResponse")]
        System.Threading.Tasks.Task<bool> UpdateGenreAsync(Client.MovieService.Genre genre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMovieServiceChannel : Client.MovieService.IMovieService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MovieServiceClient : System.ServiceModel.ClientBase<Client.MovieService.IMovieService>, Client.MovieService.IMovieService {
        
        public MovieServiceClient() {
        }
        
        public MovieServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MovieServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.MovieService.Genre[] GetGenres() {
            return base.Channel.GetGenres();
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Genre[]> GetGenresAsync() {
            return base.Channel.GetGenresAsync();
        }
        
        public Client.MovieService.Movie[] GetMovies() {
            return base.Channel.GetMovies();
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesAsync() {
            return base.Channel.GetMoviesAsync();
        }
        
        public Client.MovieService.Movie[] GetMoviesByTitle(string title) {
            return base.Channel.GetMoviesByTitle(title);
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByTitleAsync(string title) {
            return base.Channel.GetMoviesByTitleAsync(title);
        }
        
        public Client.MovieService.Movie[] GetMoviesByGenre(Client.MovieService.Genre genre) {
            return base.Channel.GetMoviesByGenre(genre);
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByGenreAsync(Client.MovieService.Genre genre) {
            return base.Channel.GetMoviesByGenreAsync(genre);
        }
        
        public Client.MovieService.Movie[] GetMoviesByTitlePart(string part) {
            return base.Channel.GetMoviesByTitlePart(part);
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByTitlePartAsync(string part) {
            return base.Channel.GetMoviesByTitlePartAsync(part);
        }
        
        public Client.MovieService.Movie[] GetMoviesByYear(int year) {
            return base.Channel.GetMoviesByYear(year);
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByYearAsync(int year) {
            return base.Channel.GetMoviesByYearAsync(year);
        }
        
        public Client.MovieService.Movie[] GetMoviesByDirector(int id) {
            return base.Channel.GetMoviesByDirector(id);
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByDirectorAsync(int id) {
            return base.Channel.GetMoviesByDirectorAsync(id);
        }
        
        public Client.MovieService.Movie[] GetMoviesByActor(int id) {
            return base.Channel.GetMoviesByActor(id);
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Movie[]> GetMoviesByActorAsync(int id) {
            return base.Channel.GetMoviesByActorAsync(id);
        }
        
        public Client.MovieService.Movie AddMovie(Client.MovieService.Movie movie) {
            return base.Channel.AddMovie(movie);
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Movie> AddMovieAsync(Client.MovieService.Movie movie) {
            return base.Channel.AddMovieAsync(movie);
        }
        
        public Client.MovieService.Genre AddGenre(Client.MovieService.Genre genre) {
            return base.Channel.AddGenre(genre);
        }
        
        public System.Threading.Tasks.Task<Client.MovieService.Genre> AddGenreAsync(Client.MovieService.Genre genre) {
            return base.Channel.AddGenreAsync(genre);
        }
        
        public void DeleteMovie(Client.MovieService.Movie movie) {
            base.Channel.DeleteMovie(movie);
        }
        
        public System.Threading.Tasks.Task DeleteMovieAsync(Client.MovieService.Movie movie) {
            return base.Channel.DeleteMovieAsync(movie);
        }
        
        public void DeleteGenre(Client.MovieService.Genre genre) {
            base.Channel.DeleteGenre(genre);
        }
        
        public System.Threading.Tasks.Task DeleteGenreAsync(Client.MovieService.Genre genre) {
            return base.Channel.DeleteGenreAsync(genre);
        }
        
        public bool UpdateMovie(Client.MovieService.Movie movie) {
            return base.Channel.UpdateMovie(movie);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateMovieAsync(Client.MovieService.Movie movie) {
            return base.Channel.UpdateMovieAsync(movie);
        }
        
        public bool UpdateGenre(Client.MovieService.Genre genre) {
            return base.Channel.UpdateGenre(genre);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateGenreAsync(Client.MovieService.Genre genre) {
            return base.Channel.UpdateGenreAsync(genre);
        }
    }
}
