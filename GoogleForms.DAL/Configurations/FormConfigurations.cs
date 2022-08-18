using GoogleForms.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DAL.Configurations
{
    public class FormConfigurations : IEntityTypeConfiguration<Form>
    {
        public void Configure(EntityTypeBuilder<Form> builder)
        {
            builder.HasData(new Form[]
            {
               new Form{ Id=1, FormDescription= "Deneme Formu Açıklaması1", FormTitle="Deneme Formu Başlığı2", },
               new Form{ Id=2, FormDescription= "Deneme Formu Açıklaması2", FormTitle="Deneme Formu Başlığı2", },

            });
        }
    }
    public class QuestionConfigurations : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(new Question[]
            {
               new Question(){ Id=1, FormId=1, QuestionTitle="Deneme Sorusu1 ", QuestionType=Common.Enums.QuestionType.CoktanSecmeli,},
               new Question(){ Id=2, FormId=1, QuestionTitle="Deneme Sorusu1 ", QuestionType=Common.Enums.QuestionType.Paragraf,},
               new Question(){ Id=3, FormId=2, QuestionTitle="Deneme Sorusu1 ", QuestionType=Common.Enums.QuestionType.KisaYanit,},
               new Question(){ Id=4, FormId=2, QuestionTitle="Deneme Sorusu1 ", QuestionType=Common.Enums.QuestionType.OnayKutulari,},

            });
        }
    }

    public class AnswerConfigurations : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasData(new Answer[]
            {
              new Answer(){ Id=1, QuestionId=1, Description="Deneme Cevabı 1", },
              new Answer(){ Id=2, QuestionId=1, Description="Deneme Cevabı 1", },
              new Answer(){ Id=3, QuestionId=1, Description="Deneme Cevabı 1", },
              new Answer(){ Id=4, QuestionId=1, Description="Deneme Cevabı 1", },
              new Answer(){ Id=5, QuestionId=1, Description="Deneme Cevabı 1", },
              new Answer(){ Id=6, QuestionId=2, Description="Deneme Cevabı 1", },
              new Answer(){ Id=7, QuestionId=3, Description="Deneme Cevabı 1", },
              new Answer(){ Id=8, QuestionId=4, Description="Deneme Cevabı 1", },
              new Answer(){ Id=9, QuestionId=4, Description="Deneme Cevabı 1", },
              new Answer(){ Id=10, QuestionId=4, Description="Deneme Cevabı 1", },
              new Answer(){ Id=11, QuestionId=4, Description="Deneme Cevabı 1", },
              new Answer(){ Id=12, QuestionId=4, Description="Deneme Cevabı 1", },
            });
        }
    }

}
