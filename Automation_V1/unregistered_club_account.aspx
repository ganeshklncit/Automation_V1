<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="unregistered_club_account.aspx.cs" Inherits="Automation_V1.unregistered_club_account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <link href="Content/custom.css" rel="stylesheet" />

    <div class="row">
     <h1>Letter of Engagement - Non-Audit Accounts Assignment for an
                Unregistered Club</h1>
    </div>
    <hr />

<div class="row">
    <div class="col-md-12">

             <div class="form-group">              

          
                     <section>

            <div>
                <p>The committee of <strong><input type="text" id="clubName"
                            name="clubName"
                            placeholder="Insert name of the club"></strong></p>

                <p>Date:<strong><input type="date" id="engagementDate"
                            name="engagementDate" required></strong></p>

                <p>Dear <strong><input type="text" id="recipientName"
                            name="recipientName" placeholder="Insert name"
                            required></strong>,</p>

                <p>We are pleased to accept the instruction to act as an
                    accountant for your club and are writing to confirm the
                    terms of our appointment. The purpose of this letter,
                    together with the attached terms and conditions, is to set
                    out our terms for carrying out the work and to clarify our
                    respective responsibilities.</p>

                <p>We are bound by the ethical guidelines of ACCA and accept
                    instructions to act for you on the basis that we will act
                    under those ethical guidelines. A copy of these guidelines
                    can be viewed at our offices on request or at <a
                        href="https://www.accaglobal.com"
                        target="_blank">www.accaglobal.com</a>.</p>
            </div>

            <div>
                <h2>Period of Engagement</h2>
                <p>This letter is effective from the <strong><input type="date"
                            id="PeriodofEngagement" name="PeriodofEngagement"
                            required></strong>. We will deal with matters
                    arising in respect of periods before the above as
                    appropriate.</p>
            </div>

            <div>
                <h2>Scope of Services to be Provided</h2>
                <h3>Our responsibility to you</h3>
                <p>We have set out the agreed scope and objectives of your
                    instructions within this letter of engagement. Any
                    subsequent changes will be discussed with you and, where
                    appropriate, a new letter of engagement will be agreed upon.
                    We shall proceed based on the instructions we have received
                    from you and will rely on you to tell us as soon as possible
                    if anything occurs that renders any information previously
                    given to us incorrect or inaccurate. We shall not be
                    responsible for any failure to advise or comment on any
                    matter that falls outside the specific scope of your
                    instructions. We cannot accept any responsibility for any
                    event, loss, or situation unless it is the expressed purpose
                    of these instructions to provide protection.</p>

                <h3>Your responsibility to us</h3>
                <p>The advice that we give can only be as good as the
                    information on which it is based. In so far as that
                    information is provided by you, or by third parties with
                    your permission, your responsibility arises as soon as
                    possible if any circumstances or facts alter, as any
                    alteration may have a significant impact on the advice
                    given. If the circumstances change therefore or your needs
                    alter, advise us of the alteration as soon as possible in
                    writing. </p>
            </div>

            <div>
                <h2>Responsibilities</h2>
                <p>As officers of the club, you are required to prepare accounts
                    (financial statements) for each financial year, which give a
                    true and fair view of the state of affairs of the club and
                    of the profit or loss of the club for that period. In
                    preparing those accounts, you are required to:</p>
                <ol>
                    <li>Select suitable accounting policies and apply them
                        consistently.</li>
                    <li>Make judgments and estimates that are reasonable and
                        prudent.</li>
                    <li>Prepare the accounts on a going concern basis unless it
                        is inappropriate to presume that the club will continue
                        in business.</li>
                </ol>
            </div>

            <div>
                <h2>Our Service to You</h2>
                <p>We shall plan our work on the basis that an independent
                    accountant's report is required unless you inform us in
                    writing that:</p>
                <ol>
                    <li>The club requires an audit of the accounts, OR</li>
                    <li>The club requires neither an audit nor an independent
                        accountant's report.</li>
                </ol>
                <p>Should you instruct us to carry out any alternative report it
                    will be necessary for us to issue a separate letter of
                    engagement. </p>
                <p>Should you inform us that the club requires neither an audit
                    nor an independent accountant’s report, then we shall have
                    no responsibilities to the club, except those specifically
                    agreed on between us in respect of other professional
                    services. </p>
                <p>Our work will be carried out in accordance with the
                    professional standards for such engagements. It will consist
                    of comparing the accounts with the accounting records kept
                    by the club, and making such limited enquiries of the
                    officers of the club as we may consider necessary for the
                    purpose of our report. </p>
                <p>As part of our normal procedures, we may request you to
                    provide written confirmation of any information or
                    explanations given by you orally during the course of our
                    work. </p>
                <p>Our work as reporting accountants will not be an audit of the
                    accounts in accordance with International Standards on
                    Auditing. Accordingly, we will not obtain any evidence
                    relating to entries in the accounting records, or to the
                    accounts or to the disclosures in the accounts. Nor will we
                    make any assessments of the estimates and judgements made by
                    you in the preparation of the accounts. Consequently our
                    work as reporting accountant will not provide any assurance
                    that the accounting records or the accounts are free from
                    material misstatement whether caused by irregularities,
                    fraud or non-compliance with law or regulations. </p>
                <p>We will attach to the accounts a report developed by the
                    Consultative Committee of Accountancy Bodies (CCAB) which
                    explains what work has been done by us, the professional
                    requirements we have to fulfil and the standard to which the
                    work has been carried out. Web links are provided in the
                    report so that you can obtain further information from the
                    Association of Chartered Certified Accountants about: </p>
                <ol>
                    <li>The technical guidance for the work, and </li>
                    <li>The related ethical and other professional
                        requirements.</li>
                </ol>
                <p>To ensure that anyone reading the accounts is aware that we
                    have not carried out an audit, we will attach to the
                    accounts a report stating this fact. </p>
                <p>The intended users of the report are the members. The report
                    will be addressed to the members. </p>
                <p>We have a professional responsibility not to allow our name
                    to be associated with accounts that may be misleading.
                    Therefore, although we are not required to search for such
                    matters, should we become aware, for any reason, that the
                    accounts may be misleading and the matter cannot be
                    adequately dealt with by means of an appropriate
                    modification of the report, we will not issue any report and
                    will withdraw from the engagement, and will notify you in
                    writing of the reasons. </p>
            </div>

            <div>
                <h2>Limitation of Liability</h2>
                <p>We specifically draw your attention to the limitation of
                    liability paragraphs in our standard terms and conditions
                    which set out the basis on which we limit our liability to
                    you and to others. You should read this in conjunction with
                    the limitation of third party rights paragraphs in our
                    standard terms and conditions which exclude liability to
                    third parties. These are important provisions which you
                    should read and consider carefully. </p>
                <p>There are no third parties that we have agreed should be
                    entitled to rely on the work done pursuant to this
                    engagement letter.</p>
            </div>

            <div>
                <h2>Other Services</h2>
                <p>You may request that we provide other services from time to
                    time. If these services will exceed £500, we will issue a
                    separate letter of engagement and scope of work to be
                    performed accordingly. </p>
                <p>Because rules and regulations frequently change, you must ask
                    us to confirm any advice already given if a transaction is
                    delayed or a similar transaction is to be undertaken. </p>
            </div>

            <div>
                <h2>Agreement of Terms</h2>
                <p>This letter supersedes any previous engagement letter for the
                    period covered. Once it has been agreed, this letter will
                    remain effective until it is replaced.</p>
                <p>You or we may vary or terminate our authority to act on your
                    behalf at any time without penalty. Notice of variation or
                    termination must be given in writing.</p>
                <p>We would be grateful if you could confirm your agreement to
                    the terms of this letter by signing the enclosed copy and
                    returning it to us immediately. </p>
                <p>If this letter is not in accordance with your understanding
                    of the scope of our engagement or your circumstances have
                    changed, please let us know. </p>
                <p>This letter should be read in conjunction with the firm’s
                    standard terms and conditions. </p>
            </div>

            <div>
                <p>Yours sincerely <br>
                    Signed,</p>
                <p class="signature">Martin R Watt</p>
                <p><strong>Martin R Watt FCCA </strong><br>
                    Thyme Tax & Accountancy Ltd </p>
            </div>

            <div class="signature-section">
                <p>I/We confirm that I/we have read and understood the contents
                    of this letter and related terms and conditions and agree
                    that it accurately reflects my/our understanding of the
                    services that I/we require you to undertake.</p>
                <p><canvas id="signature-pad" width="400" height="200"
                        style="border:1px solid #000;"></canvas>
                    <button id="clear">Clear</button>
                    <button id="save">Save</button>

                    <script
                        src="https://cdn.jsdelivr.net/npm/signature_pad@2.3.2/dist/signature_pad.min.js"></script>
                    <script>
                        var canvas = document.getElementById('signature-pad');
                        var signaturePad = new SignaturePad(canvas);

                        // Clear signature
                        document.getElementById('clear').addEventListener('click', function () {
                            signaturePad.clear();
                        });

                        // Save signature
                        document.getElementById('save').addEventListener('click', function () {
                            if (signaturePad.isEmpty()) {
                                alert("Please provide a signature first.");
                            } else {
                                var dataURL = signaturePad.toDataURL();
                                console.log(dataURL);  // This is where you can send the signature to your server or save it
                            }
                        });
                    </script>
                </p>
                <p>Date: <input type="date" id="PeriodofEngagement"
                        name="PeriodofEngagement" required></p>
                <p>For and on behalf of <strong><input type="text" id="clubName"
                            name="clubName"
                            placeholder="Insert club or officers' names"></strong></p>
            </div>

        </section>


            </div>

             <asp:HiddenField ID="txtContractnumber" runat="server"/>

            <br/>

        <asp:CheckBox ID="chkContract" runat="server" />
 
         <asp:Button ID="btnSubmit" class="btn custom-btn" runat="server" Text="Accept" 
                             Width="82px" OnClick="btnSubmit_Click" />

            </div>
    </div>

    <script>
    function alertupdate() {
        swal("Company Created Succesfully", '', "success",);
    }
    </script>

</asp:Content>
