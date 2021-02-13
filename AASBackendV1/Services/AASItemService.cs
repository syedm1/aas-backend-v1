using AutoMapper;
using BC = BCrypt.Net.BCrypt;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.AASItems;

namespace WebApi.Services
{
    public interface IAASItemService
    {
        public bool Add(AddAASItemRequestModel model);
        public IEnumerable<AASItemResponse> GetAll();
    }

    public class AASItemService : IAASItemService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        private readonly IEmailService _emailService;

        public AASItemService(
            DataContext context,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IEmailService emailService)
        {
            _context = context;
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _emailService = emailService;
        }

        public bool Add(AddAASItemRequestModel model)
        {

            try
            {
                //if (_context.AAsItems.Any(x => x.UniqueTitle == model.UniqueTitle))
                //{
                //    // send already exists

                //    return false;
                //}

                // map model to new account object
                var item = _mapper.Map<AASItem>(model);

                item.Created = DateTime.UtcNow;
                item.Updated = DateTime.UtcNow;

                // save account
                _context.AAsItems.Add(item);
                _context.SaveChanges();


                return true;
            }

            catch(Exception ex)
            {
                //log error later
                return false;
            }
           
        }

        public IEnumerable<AASItemResponse> GetAll()
        {
            var items = _context.AAsItems;
            return _mapper.Map<IList<AASItemResponse>>(items);
        }

    }
}
