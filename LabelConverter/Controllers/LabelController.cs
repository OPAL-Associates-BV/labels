﻿using System.Threading.Tasks;
using System.Web.Http;
using LabelsMain.Create;
using LabelsMain.Models;

namespace LabelConverter.Controllers
{
    public class LabelController : ApiController
    {
        public LabelController(LabelFactory factory)
        {
        }

        public Task<LabelViewModel> CreateAsync(CreateLabelRequest labelReq)
        {
            return null;
        }
    }
}