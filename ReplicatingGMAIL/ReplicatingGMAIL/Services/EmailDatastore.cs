using ReplicatingGMAIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReplicatingGMAIL.Services
{
    public class EmailDatastore : IDataStore<Email>
    {
        //Liste des emails
        readonly List<Email> _emails;

        /// <summary>
        /// Constructeur
        /// </summary>
        public EmailDatastore()
        {


            _emails = new List<Email>()
            {
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Angelo Davilla", SousTitreEmail="Relevez le defi suivant",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("040233"), Favoris=false, Time= DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Binance",SousTitreEmail="Relevez le defi de la chasse aux tresors",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("aed67e"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "XhamsterLive", SousTitreEmail="Here's what you haven't seen yet",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("4fc2fb"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Udemy Instructor",SousTitreEmail="Start your Arduino Adventure",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("fabd26"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Facebook", SousTitreEmail="Janes Samantha a demandé a rejoindre votre groupe",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("04867c"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Medium Daily Digest", SousTitreEmail="How to build your own custom renderer",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("FF6A00"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Angelo Davilla", SousTitreEmail="Relevez le defi suivant",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("040233"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Binance",SousTitreEmail="Relevez le defi de la chasse aux tresors",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("aed67e"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "XhamsterLive", SousTitreEmail="Here's what you haven't seen yet",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("4fc2fb"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Udemy Instructor",SousTitreEmail="Start your Arduino Adventure",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("fabd26"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Facebook", SousTitreEmail="Janes Samantha a demandé a rejoindre votre groupe",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("04867c"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Angelo Davilla", SousTitreEmail="Relevez le defi suivant",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("040233"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Binance",SousTitreEmail="Relevez le defi de la chasse aux tresors",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("aed67e"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "XhamsterLive", SousTitreEmail="Here's what you haven't seen yet",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("4fc2fb"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Udemy Instructor",SousTitreEmail="Start your Arduino Adventure",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("fabd26"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Facebook", SousTitreEmail="Janes Samantha a demandé a rejoindre votre groupe",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("04867c"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Medium Daily Digest", SousTitreEmail="How to build your own custom renderer",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("FF6A00"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Angelo Davilla", SousTitreEmail="Relevez le defi suivant",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("040233"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Binance",SousTitreEmail="Relevez le defi de la chasse aux tresors",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("aed67e"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "XhamsterLive", SousTitreEmail="Here's what you haven't seen yet",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("4fc2fb"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Udemy Instructor",SousTitreEmail="Start your Arduino Adventure",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("#fabd26"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Facebook", SousTitreEmail="Janes Samantha a demandé a rejoindre votre groupe",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("04867c"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Angelo Davilla", SousTitreEmail="Relevez le defi suivant",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("040233"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Binance",SousTitreEmail="Relevez le defi de la chasse aux tresors",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("aed67e"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "XhamsterLive", SousTitreEmail="Here's what you haven't seen yet",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("4fc2fb"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Udemy Instructor",SousTitreEmail="Start your Arduino Adventure",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("fabd26"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Facebook", SousTitreEmail="Janes Samantha a demandé a rejoindre votre groupe",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("04867c"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Medium Daily Digest", SousTitreEmail="How to build your own custom renderer",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("FF6A00"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Angelo Davilla", SousTitreEmail="Relevez le defi suivant",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("040233"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Binance",SousTitreEmail="Relevez le defi de la chasse aux tresors",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("aed67e"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "XhamsterLive", SousTitreEmail="Here's what you haven't seen yet",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("4fc2fb"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Udemy Instructor",SousTitreEmail="Start your Arduino Adventure",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("fabd26"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Facebook", SousTitreEmail="Janes Samantha a demandé a rejoindre votre groupe",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("04867c"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Angelo Davilla", SousTitreEmail="Relevez le defi suivant",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("040233"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Binance",SousTitreEmail="Relevez le defi de la chasse aux tresors",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("aed67e"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "XhamsterLive", SousTitreEmail="Here's what you haven't seen yet",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("4fc2fb"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Udemy Instructor",SousTitreEmail="Start your Arduino Adventure",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("fabd26"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Facebook", SousTitreEmail="Janes Samantha a demandé a rejoindre votre groupe",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("04867c"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Medium Daily Digest", SousTitreEmail="How to build your own custom renderer",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("FF6A00"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Angelo Davilla", SousTitreEmail="Relevez le defi suivant",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("040233"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Binance",SousTitreEmail="Relevez le defi de la chasse aux tresors",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("aed67e"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "XhamsterLive", SousTitreEmail="Here's what you haven't seen yet",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("4fc2fb"), Favoris=true, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Udemy Instructor",SousTitreEmail="Start your Arduino Adventure",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("fabd26"), Favoris=false, Time=DateTime.Now},
                new Email { Id = Guid.NewGuid().ToString(), TitleEmail = "Facebook", SousTitreEmail="Janes Samantha a demandé a rejoindre votre groupe",DescriptionEmail="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud",ColorImageEmail= Color.FromHex("04867c"), Favoris=true, Time=DateTime.Now}
            };
        }


        /// <summary>
        /// Ajouter un element a la liste
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<bool> AddItemAsync(Email item)
        {
            _emails.Add(item);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// Supprimer un element dans la liste
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = _emails.Where((Email arg) => arg.Id == id).FirstOrDefault();
            _emails.Remove(oldItem);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// Obtenir detail sur un elemnt de la liste
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Email> GetItemAsync(string id)
        {
            return await Task.FromResult(_emails.FirstOrDefault(s => s.Id == id));
        }

        /// <summary>
        /// Obtenir la liste des elements par refresh de liste
        /// </summary>
        /// <param name="forceRefresh"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Email>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_emails);
        }

        /// <summary>
        /// Mise a jour d'un element dans la liste
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<bool> UpdateItemAsync(Email item)
        {
            var oldItem = _emails.Where((Email arg) => arg.Id == item.Id).FirstOrDefault();
            _emails.Remove(oldItem);
            _emails.Add(item);

            return await Task.FromResult(true);
        }
    }
}
