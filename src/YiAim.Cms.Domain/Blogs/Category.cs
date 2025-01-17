﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Yitter.IdGenerator;

namespace YiAim.Cms.Blogs;
public class Category : AuditedEntity<long>, ITaxis
{
    public Category()
    {
        this.Id = YitIdHelper.NextId();
    }
    //public Category()
    //{
    //    Blogs = new HashSet<Blog>();
    //}
    [NotNull]
    [MaxLength(150)]
    public string Title { get; set; }
    public int Taxis { get; set; } = 0;
    // public ICollection<Blog> Blogs { get; set; }

    public void SetId(long id)
    {
        this.Id = id;
    }
}
