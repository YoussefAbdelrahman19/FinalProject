
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace GradProjectV5.Models
{

using System;
    using System.Collections.Generic;
    
public partial class ConsultAnswer
{

    public int ID { get; set; }

    public Nullable<int> ConsultId { get; set; }

    public string Answer { get; set; }

    public Nullable<int> AnsweredById { get; set; }

    public Nullable<System.DateTime> AnswerDate { get; set; }

    public Nullable<bool> IsDeleted { get; set; }



    public virtual Consult Consult { get; set; }

    public virtual Member Member { get; set; }

}

}