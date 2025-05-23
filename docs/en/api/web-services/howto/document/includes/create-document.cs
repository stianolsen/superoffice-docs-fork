public int CreateDocument()
{
  //create new instance
  using(DocumentAgent agent = new DocumentAgent())
  {
    // create a document entity
    DocumentEntity documentEntity = agent.CreateDefaultDocumentEntity();
  
    // set properties of document entity
    documentEntity.Attention = "Thomas O S";
    documentEntity.Header = "Test document";
    documentEntity.Name = "Test.doc";
    documentEntity.OurRef = "Our Reference";
    documentEntity.YourRef = "Your Reference";
    documentEntity.Description = "This is a new document entity created using IDocument Agent";
    documentEntity.Date = DateTime.Today;
    documentEntity.ExternalRef = "External Reference";
  
    // use the ListAgent to get the document template.
    // this will ensure all the correct properties are set, i.e. document plugin (autoeventid and archiveprovider)
    using(ListAgent listAgent = new ListAgent())
    {
      documentEntity.DocumentTemplate = listAgent.GetDocumentTemplate(1)
    }
    
    // set the owner of the document
    Associate owner = new Associate();
    owner.AssociateId = 110;
    documentEntity.Associate = owner;
  
  
    // set the person to whom the document is connected : optional
    Person person = new Person();
    person.PersonId = 12;
    documentEntity.Person = person;
  
    // set the contact associated with the document: can also be null
    Contact contact = new Contact();
    contact.ContactId = 4;
    documentEntity.Contact = contact;
  
    // set the project to which the document is connected  : optional
    Project project = new Project();
    project.ProjectId = 15;
    documentEntity.Project = project;

    // save the document record in the database
    DocumentEntity createdDocumentEntity = agent.SaveDocumentEntity(documentEntity);

    // create a physical document for the corresponding record and store it in the document archive
    agent.CreateNewPhysicalDocumentFromTemplate(
       createdDocumentEntity.Contact.ContactId, 
       createdDocumentEntity.Person.PersonId, 
       0, 
       createdDocumentEntity.DocumentId, 
       0, 
       0, 
       createdDocumentEntity.Project.ProjectId);

    return createdDocumentEntity.DocumentId;
  }
}
