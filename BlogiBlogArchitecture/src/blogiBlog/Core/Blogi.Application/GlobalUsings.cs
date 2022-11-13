﻿global using System;
global using MediatR;
global using AutoMapper;
global using System.Linq;
global using System.Text;
global using FluentValidation;
global using System.Reflection;
global using Blogi.Domain.Entities;
global using System.Threading.Tasks;
global using Microsoft.AspNetCore.Http;
global using Core.Application.Responses;
global using System.Collections.Generic;
global using Blogi.Application.Services.TagService;
global using Blogi.Application.Services.PostService;
global using Core.Application.FormAuth.ClaimServices;
global using Microsoft.Extensions.DependencyInjection;
global using Core.Persistence.Repositories.Interfaces;
global using Blogi.Application.Services.PostTagService;
global using Blogi.Application.Features.Tags.Constants;
global using Blogi.Application.Features.Auth.Constants;
global using Blogi.Application.Features.Posts.Constants;
global using Blogi.Application.Services.CategoryService;
global using Blogi.Application.Features.Users.Constants;
global using Blogi.Application.Repositories.TagRepository;
global using Blogi.Application.Features.PostsTags.Constants;
global using Blogi.Application.Repositories.PostRepository;
global using Blogi.Application.Repositories.UserRepository;
global using Blogi.Application.Features.Languages.Constants;
global using Blogi.Application.Features.Categories.Constants;
global using Blogi.Application.Services.StringResourceService;
global using Blogi.Application.Repositories.CategoryRepository;
global using Blogi.Application.Repositories.LanguageRepository;
global using Blogi.Application.Features.MailSettings.Constants;
global using Blogi.Application.Repositories.PostTagsRepository;
global using Blogi.Application.Repositories.MailSettingRepository;
global using Blogi.Application.Features.StringResources.Constants;
global using Blogi.Application.Repositories.StringResourceRepository;
