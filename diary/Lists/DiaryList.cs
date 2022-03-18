using diary.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace diary.Lists
{
    public class DiaryList
    {
        public ObservableCollection<Diary> Diaries { get; set; }

        Person person = DependencyService.Get<PersonList>().Persons.ToList().Where(X => X.Email == "rumeysa@gmail.com").FirstOrDefault();
        Person person1 = DependencyService.Get<PersonList>().Persons.ToList().Where(X => X.Email == "nisa@gmail.com").FirstOrDefault();


        public DiaryList()
        {
            Diaries = new ObservableCollection<Diary>();
            Diaries.Add(new Diary
            {

                Person = person,
                Date = DateTime.Now,
                Title = "Travel",
                Text = "Dear Diary Today I went to Bangalore railway station Yeshwantpura to receive my uncle and aunt who were coming from Mumbai It was a bright sunny day." +
                "Sun was shining like a star.While I and my father" +
                " were crossing the Orion mall, we saw three elephants that made me reminded of my Kerala trip" +
                " Last year I went on a Kerala trip, " +
                "where we visited around 5 cities like Cochin, " +
                "Wayanad, Munnar, Kovalam, and Alappuzha.All the places were really awesome and beautiful." +
                "Then we went to Elephant junction Thekkady, Kumily, where people go for elephant rides. I rode sitting above the elephant around for 2" +
                " and half hours.Then we have also done elephant bath and feeding.We took a lot of pictures with elephants.It was a nice trip and I still can’t get over it.",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRDAbekOB3hI03Na9DNeW98mFKadwoUh_9tcxxVVo21pHkavSfyKnnaMrinkxtzw12mPXQ&usqp=CAU",
                Point = 9


            });
            Diaries.Add(new Diary
            {
                Person = person,
                Date = DateTime.Now,
                Title = "Holiday",
                Text = "Today has been great! I enjoyed my holiday." +
                " We had a breakfast at home in the morning. Then I wore my" +
                " swimsuit and we swum in the sea. The weather was very good and" +
                " I sunbatheAfter I swum in the sea,I went home and I had a shower.We " +
                "went shopping with my father for the dinner. We bought chicken from the " +
                "supermarkAfter the dinner, we ate ice - cream with my brother.I was very tired so I rested.See you tomorrow",
                ImageUrl = "https://laurenonlocation.com/wp-content/uploads/2019/06/felix-rostig-UmV2wr-Vbq8-unsplash-1024x683.jpg",
                Point = 8



            }); Diaries.Add(new Diary
            {
                Person = person,
                Title = "My Birthday",
                Date = DateTime.Now,
                Text = "Dear Diary,Today was my birthday! We had a dinner with my parents.It was so lovely." +
                "My grandparents phoned me and congratulated my birthday." +
                " Guess what ? My best friend Mary had organized a birthday party for me! After dinner, my friends and I went outside and had some fun." +
                "I wore an orange dress and I tied up my hairs.I was sooo exited!" +
                "Nearly all my friends bought me a present.They made me happy.Mary stayed" +
                " over in our home and we watched a film at night.After we watched the film," +
                " we slept.I was so happy and I felt myself so lucky to have such a friend.Jane",
                ImageUrl = "https://media.istockphoto.com/photos/happy-birthday-to-you-concept-picture-id1154066614?k=20&m=1154066614&s=170667a&w=0&h=CRDA7A7EbeUb5lmJ9HPjwjfbDtZlJhkRXit31DRC1dw=",
                Point = 8

            });
            Diaries.Add(new Diary
            {
                Person = person,
                Title = "Learning to Swim",
                Date = DateTime.Now,
                Text = "Dear Diary, Misfortunes never follow a calendar.They come uninvited." +
                "I was sitting at the deeper side of the NDMC swimming pool.A strong and sturdy" +
                " boy came.He mocked me by saying, “Hey skinny!” Before I could react, the muscular " +
                "rascal pushed me into the pool.I found myself at the bottom.The depth of the pool was" +
                " not less than nine feet.I didn’t know how to swim.I struggled to come up.My arms and legs" +
                " were totally paralysed.I felt suffocated.I thought that my end was near.Later on," +
                "when I came to senses, I found myself vomiting at the other end of the pool." +
                "I pledged myself to become a perfect swimmer.I employed a professional trainer.He was a hard " +
                "taskmaster and made me sweat three hours for weeks.He taught me inhaling, exhaling and diving into " +
                "the pool.My hard labour and my trainer’s professional coaching were rewarded.I participated in a swimming" +
                " competition organised by a local club.And the most unexpected happened.I led the rest by a comfortable margin." +
                "My dream had come true.I had become a perfect swimmer.",
                ImageUrl = "https://nblturkiye.com/wp-content/uploads/Y%C3%BCzme-sporu-e1574413734942.jpg",
                Point = 7

            });
        }


    }
}
